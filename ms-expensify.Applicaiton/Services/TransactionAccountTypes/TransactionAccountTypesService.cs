using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using ms_expensify.Application.Contracts.Repositories;
using ms_expensify.Application.Services.TransactionAccountTypes.ViewModels;

namespace ms_expensify.Application.Services.TransactionAccountTypes
{
    public class TransactionAccountTypesService : ITransactionAccountTypesService
    {
        private readonly ITransactionAccountTypesRepository _transactionAccountTypesRepository;
        private readonly IMapper _mapper;

        public TransactionAccountTypesService(ITransactionAccountTypesRepository transactionAccountTypesRepository, IMapper mapper)
        {
            _transactionAccountTypesRepository = transactionAccountTypesRepository;
            _mapper = mapper;
        }

        public async Task<List<TransactionAccountTypeViewModel>> GetByFilters(CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            return await _transactionAccountTypesRepository
                .GetByFilters(x => x)
                .ProjectTo<TransactionAccountTypeViewModel>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);
        }
    }
}
