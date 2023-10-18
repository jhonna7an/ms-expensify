using ms_expensify.Application.Services.TransactionAccounts.ViewModels;

namespace ms_expensify.Application.Services.TransactionAccounts
{
    public interface ITransactionAccountsService
    {
        Task<TransactionAccountViewModel> GetById(int id, CancellationToken cancellationToken);
        Task<List<TransactionAccountViewModel>> GetByFilters(TransactionAccountFilterViewModel filters, CancellationToken cancellationToken);
        Task<TransactionAccountViewModel> Create(TransactionAccountPostViewModel entityToAdd, CancellationToken cancellationToken);
        Task<TransactionAccountViewModel> Patch(int id, TransactionAccountPatchViewModel entityToUpdate, CancellationToken cancellationToken);
        Task Delete(int id, CancellationToken cancellationToken);
    }
}
