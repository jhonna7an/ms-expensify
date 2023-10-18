using AutoMapper;
using AutoMapper.QueryableExtensions;
using Goof.Infraestructure.Repository.UoW;
using Microsoft.EntityFrameworkCore;
using ms_expensify.Application.Contracts.Repositories;
using ms_expensify.Application.Services.TransactionAccounts.ViewModels;
using ms_expensify.Domain.Entities;
using ms_expensify.Domain.Enums;

namespace ms_expensify.Application.Services.TransactionAccounts
{
    public class TransactionAccountsService : ITransactionAccountsService
    {
        private readonly ITransactionAccountsRepository _transactionAccountsRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public TransactionAccountsService(
            ITransactionAccountsRepository transactionAccountsRepository,
            IUnitOfWork unitOfWork,
            IMapper mapper
        )
        {
            _transactionAccountsRepository = transactionAccountsRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<TransactionAccountViewModel> GetById(int id, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            IQueryable<TransactionAccount> applyFilters(IQueryable<TransactionAccount> query) => _applyFilters(query, new TransactionAccountFilterViewModel
            {
                Id = id
            });

            IQueryable<TransactionAccount> transactionAccounts = _transactionAccountsRepository.GetByFilters(applyFilters, cancellationToken: cancellationToken);
            
            return await transactionAccounts.ProjectTo<TransactionAccountViewModel>(_mapper.ConfigurationProvider)
                .FirstOrDefaultAsync(cancellationToken);
        }

        public async Task<List<TransactionAccountViewModel>> GetByFilters(TransactionAccountFilterViewModel filters, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            IQueryable<TransactionAccount> applyFilters(IQueryable<TransactionAccount> query) => _applyFilters(query, filters);

            IQueryable<TransactionAccount> transactionAccounts = _transactionAccountsRepository
                .GetByFilters(applyFilters, propertiesIncluded: "Currency", cancellationToken: cancellationToken);

            return await transactionAccounts.ProjectTo<TransactionAccountViewModel>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);
        }

        public async Task<TransactionAccountViewModel> Create(TransactionAccountPostViewModel entityToAdd, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            TransactionAccount transactionAccount = _mapper.Map<TransactionAccount>(entityToAdd);
            await _transactionAccountsRepository.Insert(transactionAccount, cancellationToken);
            _unitOfWork.SaveChanges();

            return await GetById(transactionAccount.Id, cancellationToken);
        }

        public async Task<TransactionAccountViewModel> Patch(int id, TransactionAccountPatchViewModel entityToUpdate, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            IQueryable<TransactionAccount> applyFilters(IQueryable<TransactionAccount> query) => _applyFilters(query, new TransactionAccountFilterViewModel
            {
                Id = id
            });

            TransactionAccount transactionAccount =  _transactionAccountsRepository
                .GetByFilters(applyFilters, cancellationToken: cancellationToken)
                .FirstOrDefault()!;

            if (transactionAccount is null)
                throw new Exception("No se encontró la cuenta");

            _mapper.Map(entityToUpdate, transactionAccount);

            _transactionAccountsRepository.Update(transactionAccount, cancellationToken);
            _unitOfWork.SaveChanges();

            return await GetById(transactionAccount.Id, cancellationToken);
        }

        public async Task Delete(int id, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            IQueryable<TransactionAccount> applyFilters(IQueryable<TransactionAccount> query) => _applyFilters(query, new TransactionAccountFilterViewModel
            {
                Id = id
            });

            TransactionAccount transactionAccount = _transactionAccountsRepository
                .GetByFilters(applyFilters, cancellationToken: cancellationToken)
                .FirstOrDefault()!;

            if (transactionAccount is null)
                throw new Exception("No se encontró la cuenta");

            _transactionAccountsRepository.Delete(transactionAccount, cancellationToken);
            await _unitOfWork.SaveChangesAsync();
        }

        private IQueryable<TransactionAccount> _applyFilters(IQueryable<TransactionAccount> query, TransactionAccountFilterViewModel filters)
        {
            query = query.Where(x => x.Status != (int)StatusEnum.Deleted).AsQueryable();

            if (filters.Id.HasValue)
                query = query.Where(x => x.Id == filters.Id.Value);

            if (filters.UserId.HasValue)
                query = query.Where(x => x.UserId == filters.UserId.Value);

            return query;
        }
    }
}
