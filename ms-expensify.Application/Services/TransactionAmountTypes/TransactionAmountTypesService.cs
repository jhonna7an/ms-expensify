using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using ms_expensify.Application.Contracts.Repositories;
using ms_expensify.Application.Services.TransactionAmountTypes.ViewModels;

namespace ms_expensify.Application.Services.TransactionAmountTypes
{
    public class TransactionAmountTypesService : ITransactionAmountTypesService
    {
        private readonly ITransactionAmountTypesRepository _transactionAmountTypesRepository;
        private readonly IMapper _mapper;

        public TransactionAmountTypesService(ITransactionAmountTypesRepository transactionAmountTypesRepository, IMapper mapper)
        {
            _transactionAmountTypesRepository = transactionAmountTypesRepository;
            _mapper = mapper;
        }

        public async Task<List<TransactionAmountTypeViewModel>> GetByFilters(CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            return await _transactionAmountTypesRepository
                .GetByFilters(x => x)
                .ProjectTo<TransactionAmountTypeViewModel>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);
        }
    }
}
