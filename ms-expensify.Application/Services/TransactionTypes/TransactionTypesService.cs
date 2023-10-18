using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using ms_expensify.Application.Contracts.Repositories;
using ms_expensify.Application.Services.TransactionTypes.ViewModels;

namespace ms_expensify.Application.Services.TransactionTypes
{
    public class TransactionTypesService : ITransactionTypesService
    {
        private readonly ITransactionTypesRepository _transactionTypesRepository;
        private readonly IMapper _mapper;

        public TransactionTypesService(ITransactionTypesRepository transactionTypesRepository, IMapper mapper)
        {
            _transactionTypesRepository = transactionTypesRepository;
            _mapper = mapper;
        }

        public async Task<List<TransactionTypeViewModel>> GetByFilters(CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            return await _transactionTypesRepository
                .GetByFilters(x => x)
                .ProjectTo<TransactionTypeViewModel>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);
        }
    }
}
