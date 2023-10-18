using AutoMapper;
using AutoMapper.QueryableExtensions;
using Goof.Infraestructure.Repository.UoW;
using Microsoft.EntityFrameworkCore;
using ms_expensify.Application.Contracts.Repositories;
using ms_expensify.Application.Services.Plannings.ViewModels;
using ms_expensify.Application.Services.TransactionStates.Enums;
using ms_expensify.Domain.Entities;
using ms_expensify.Domain.Enums;

namespace ms_expensify.Application.Services.Plannings
{
    public class PlanningsService : IPlanningsService
    {
        private readonly IPlanningsRepository _planningsRepository;
        private readonly ITransactionsRepository _transactionsRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public PlanningsService(
            IPlanningsRepository planningsRepository, 
            ITransactionsRepository transactionsRepository,
            IMapper mapper, 
            IUnitOfWork unitOfWork
        )
        {
            _planningsRepository = planningsRepository;
            _transactionsRepository = transactionsRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<PlanningViewModel> GetById(int id, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            IQueryable<Planning> applyFilters(IQueryable<Planning> query) => _applyFilters(query, new PlanningFilterViewModel
            {
                Id = id
            });

            IQueryable<Planning> plannings = _planningsRepository.GetByFilters(applyFilters, cancellationToken: cancellationToken);

            return await plannings.ProjectTo<PlanningViewModel>(_mapper.ConfigurationProvider)
                .FirstOrDefaultAsync(cancellationToken);
        }


        public async Task<List<PlanningViewModel>> GetByFilters(PlanningFilterViewModel filters, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            IQueryable<Planning> applyFilters(IQueryable<Planning> query) => _applyFilters(query, filters);

            IQueryable<Planning> plannings = _planningsRepository
                .GetByFilters(applyFilters, cancellationToken: cancellationToken);

            return await plannings.ProjectTo<PlanningViewModel>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);
        }

        public async Task<PlanningViewModel> Create(PlanningPostViewModel entityToAdd, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            Planning planning = _mapper.Map<Planning>(entityToAdd);
            await _planningsRepository.Insert(planning, cancellationToken);
            _unitOfWork.SaveChanges();

            return await GetById(planning.Id, cancellationToken);
        }

        public async Task<PlanningViewModel> Patch(int id, PlanningPatchViewModel entityToUpdate, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            IQueryable<Planning> applyFilters(IQueryable<Planning> query) => _applyFilters(query, new PlanningFilterViewModel
            {
                Id = id
            });

            Planning planning = _planningsRepository
                .GetByFilters(applyFilters, cancellationToken: cancellationToken)
                .FirstOrDefault()!;

            if (planning is null)
                throw new Exception("No se encontró la planificación");

            _mapper.Map(entityToUpdate, planning);

            _planningsRepository.Update(planning, cancellationToken);
            _unitOfWork.SaveChanges();

            return await GetById(planning.Id, cancellationToken);
        }

        public async Task PatchByTransactions(int id, int userId, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            IQueryable<Planning> applyFilters(IQueryable<Planning> query) => _applyFilters(query, new PlanningFilterViewModel
            {
                Id = id
            });

            Planning? planning = await _planningsRepository
                .GetByFilters(applyFilters, propertiesIncluded: "Transactions", cancellationToken: cancellationToken)
                .FirstOrDefaultAsync(cancellationToken);

            if (planning is null) throw new Exception("No se encontró la planificación");

            List<Transaction> transactionsToUpdate = planning.Transactions
                .Select(ent =>
                {
                    ent.TransactionStateId = (int)TransactionStatesEnum.Active;
                    ent.LastModifiedAt = DateTime.UtcNow;
                    ent.LastModifiedBy = userId;
                    return ent;
                })
                .ToList();

            _transactionsRepository.UpdateRange(transactionsToUpdate, cancellationToken);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task Delete(int id, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            IQueryable<Planning> applyFilters(IQueryable<Planning> query) => _applyFilters(query, new PlanningFilterViewModel
            {
                Id = id
            });

            Planning planning = _planningsRepository
                .GetByFilters(applyFilters, cancellationToken: cancellationToken)
                .FirstOrDefault()!;

            if (planning is null)
                throw new Exception("No se encontró la planificación");

            _planningsRepository.Delete(planning, cancellationToken);
            await _unitOfWork.SaveChangesAsync();
        }

        private IQueryable<Planning> _applyFilters(IQueryable<Planning> query, PlanningFilterViewModel filters)
        {
            query = query.Where(x => x.Status != (int)StatusEnum.Deleted).AsQueryable();

            if (filters.Id.HasValue)
                query = query.Where(x => x.Id == filters.Id.Value);

            if (filters.TransactionAccountId != null)
                query = query.Where(x => x.TransactionAccountId == filters.TransactionAccountId.Value);

            if (filters.FromCreationDate.HasValue)
                query = query.Where(p => p.CreatedAt >= filters.FromCreationDate);

            if (filters.ToCreationDate.HasValue)
                query = query.Where(p => p.CreatedAt <= filters.ToCreationDate);

            return query;
        }
    }
}
