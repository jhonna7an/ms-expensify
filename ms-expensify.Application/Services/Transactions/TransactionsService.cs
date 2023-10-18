using AutoMapper;
using AutoMapper.QueryableExtensions;
using Goof.Infraestructure.Repository.UoW;
using Microsoft.EntityFrameworkCore;
using ms_expensify.Application.Contracts.Repositories;
using ms_expensify.Application.Services.Transactions.ViewModels;
using ms_expensify.Domain.Entities;
using ms_expensify.Domain.Enums;

namespace ms_expensify.Application.Services.Transactions
{
    public class TransactionsService : ITransactionsService
    {
        private readonly ITransactionsRepository _transactionsRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public TransactionsService(
            ITransactionsRepository transactionsRepository,
            IUnitOfWork unitOfWork,
            IMapper mapper
        )
        {
            _transactionsRepository = transactionsRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<TransactionViewModel> GetById(int id, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            IQueryable<Transaction> applyFilters(IQueryable<Transaction> query) => _applyFilters(query, new TransactionFilterViewModel
            {
                Id = id
            });

            IQueryable<Transaction> transactionAccounts = _transactionsRepository.GetByFilters(applyFilters, cancellationToken: cancellationToken);

            return await transactionAccounts.ProjectTo<TransactionViewModel>(_mapper.ConfigurationProvider)
                .FirstOrDefaultAsync(cancellationToken);
        }


        public async Task<List<TransactionViewModel>> GetByFilters(TransactionFilterViewModel filters, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            IQueryable<Transaction> applyFilters(IQueryable<Transaction> query) => _applyFilters(query, filters);

            IQueryable<Transaction> transactions = _transactionsRepository
                .GetByFilters(applyFilters, propertiesIncluded: "TransactionDetails", cancellationToken: cancellationToken);

            return await transactions.ProjectTo<TransactionViewModel>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);
        }

        public async Task<TransactionViewModel> Create(TransactionPostViewModel entityToAdd, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            Transaction transaction = _mapper.Map<Transaction>(entityToAdd);
            await _transactionsRepository.Insert(transaction, cancellationToken);
            _unitOfWork.SaveChanges();

            return await GetById(transaction.Id, cancellationToken);
        }

        public async Task<TransactionViewModel> Patch(int id, TransactionPatchViewModel entityToUpdate, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            IQueryable<Transaction> applyFilters(IQueryable<Transaction> query) => _applyFilters(query, new TransactionFilterViewModel
            {
                Id = id
            });

            Transaction transaction = _transactionsRepository
                .GetByFilters(applyFilters, cancellationToken: cancellationToken)
                .FirstOrDefault()!;

            if (transaction is null)
                throw new Exception("No se encontró la cuenta");

            _mapper.Map(entityToUpdate, transaction);

            _transactionsRepository.Update(transaction, cancellationToken);
            _unitOfWork.SaveChanges();

            return await GetById(transaction.Id, cancellationToken);
        }

        public async Task Delete(int id, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            IQueryable<Transaction> applyFilters(IQueryable<Transaction> query) => _applyFilters(query, new TransactionFilterViewModel
            {
                Id = id
            });

            Transaction transaction = _transactionsRepository
                .GetByFilters(applyFilters, cancellationToken: cancellationToken)
                .FirstOrDefault()!;

            if (transaction is null)
                throw new Exception("No se encontró la cuenta");

            _transactionsRepository.Delete(transaction, cancellationToken);
            await _unitOfWork.SaveChangesAsync();
        }

        private IQueryable<Transaction> _applyFilters(IQueryable<Transaction> query, TransactionFilterViewModel filters)
        {
            query = query.Where(x => x.Status != (int)StatusEnum.Deleted).AsQueryable();

            if (filters.Id.HasValue)
                query = query.Where(x => x.Id == filters.Id.Value);

            if (filters.PlanningId.HasValue)
                query = query.Where(x => x.PlanningId == filters.PlanningId.Value);

            if (filters.TransactionAccountId.HasValue)
                query = query.Where(x => x.TransactionAccountId == filters.TransactionAccountId.Value);

            if (filters.TransactionTypeId.HasValue)
                query = query.Where(x => x.TransactionTypeId == filters.TransactionTypeId.Value);

            return query;
        }
    }
}
