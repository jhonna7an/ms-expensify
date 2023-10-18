using ms_expensify.Application.Services.Transactions.ViewModels;

namespace ms_expensify.Application.Services.Transactions
{
    public interface ITransactionsService
    {
        Task<TransactionViewModel> GetById(int id, CancellationToken cancellationToken);
        Task<List<TransactionViewModel>> GetByFilters(TransactionFilterViewModel filters, CancellationToken cancellationToken);
        Task<TransactionViewModel> Create(TransactionPostViewModel entityToAdd, CancellationToken cancellationToken);
        Task<TransactionViewModel> Patch(int id, TransactionPatchViewModel entityToUpdate, CancellationToken cancellationToken);
        Task Delete(int id, CancellationToken cancellationToken);
    }
}
