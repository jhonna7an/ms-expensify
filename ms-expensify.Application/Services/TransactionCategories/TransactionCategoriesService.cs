using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using ms_expensify.Application.Contracts.Repositories;
using ms_expensify.Application.Services.TransactionAccounts.ViewModels;
using ms_expensify.Application.Services.TransactionCategories.ViewModels;
using ms_expensify.Domain.Entities;
using ms_expensify.Domain.Enums;

namespace ms_expensify.Application.Services.TransactionCategories
{
    public class TransactionCategoriesService : ITransactionCategoriesService
    {
        private readonly ITransactionCategoriesRepository _transactionCategoriesRepository;
        private readonly IMapper _mapper;

        public TransactionCategoriesService(ITransactionCategoriesRepository transactionCategoriesRepository, IMapper mapper)
        {
            _transactionCategoriesRepository = transactionCategoriesRepository;
            _mapper = mapper;
        }

        public async Task<List<TransactionCategoryViewModel>> GetByFilters(TransactionCategoryFilterViewModel filters, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            IQueryable<TransactionCategory> applyFilters(IQueryable<TransactionCategory> query) => _applyFilters(query, filters);

            IQueryable<TransactionCategory> transactionAccounts = _transactionCategoriesRepository
                .GetByFilters(applyFilters, cancellationToken: cancellationToken);

            return await transactionAccounts.ProjectTo<TransactionCategoryViewModel>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);
        }

        private IQueryable<TransactionCategory> _applyFilters(IQueryable<TransactionCategory> query, TransactionCategoryFilterViewModel filters)
        {
            query = query.Where(x => x.Status != (int)StatusEnum.Deleted).AsQueryable();

            if (filters.Id.HasValue)
                query = query.Where(x => x.Id == filters.Id.Value);

            if (filters.TransactionTypeId.HasValue)
                query = query.Where(x => x.TransactionTypeId == filters.TransactionTypeId.Value);

            return query;
        }
    }
}
