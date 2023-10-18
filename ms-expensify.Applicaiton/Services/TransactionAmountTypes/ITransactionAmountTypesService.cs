using ms_expensify.Application.Services.TransactionAmountTypes.ViewModels;

namespace ms_expensify.Application.Services.TransactionAmountTypes
{
    public interface ITransactionAmountTypesService
    {
        Task<List<TransactionAmountTypeViewModel>> GetByFilters(CancellationToken cancellationToken);
    }
}
