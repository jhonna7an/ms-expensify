using ms_expensify.Application.Services.TransactionDetails.ViewModels;

namespace ms_expensify.Application.Services.TransactionDetails
{
    public interface ITransactionDetailsService
    {
        Task<TransactionDetailViewModel> GetById(int id, CancellationToken cancellationToken);
        Task<TransactionDetailViewModel> Create(int transactionId, TransactionDetailPostViewModel entityToAdd, CancellationToken cancellationToken);
        Task<TransactionDetailViewModel> Patch(int id, TransactionDetailPatchViewModel entityToUpdate, CancellationToken cancellationToken);
        Task Delete(int id, CancellationToken cancellationToken);
    }
}
