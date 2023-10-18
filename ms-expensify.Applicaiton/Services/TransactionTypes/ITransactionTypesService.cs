using ms_expensify.Application.Services.TransactionTypes.ViewModels;

namespace ms_expensify.Application.Services.TransactionTypes
{
    public interface ITransactionTypesService
    {
        Task<List<TransactionTypeViewModel>> GetByFilters(CancellationToken cancellationToken);
    }
}
