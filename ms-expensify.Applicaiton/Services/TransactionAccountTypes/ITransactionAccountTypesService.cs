using ms_expensify.Application.Services.TransactionAccountTypes.ViewModels;

namespace ms_expensify.Application.Services.TransactionAccountTypes
{
    public interface ITransactionAccountTypesService
    {
        Task<List<TransactionAccountTypeViewModel>> GetByFilters(CancellationToken cancellationToken);
    }
}
