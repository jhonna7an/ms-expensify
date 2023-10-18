using ms_expensify.Application.Services.TransactionCategories.ViewModels;

namespace ms_expensify.Application.Services.TransactionCategories
{
    public interface ITransactionCategoriesService
    {
        Task<List<TransactionCategoryViewModel>> GetByFilters(TransactionCategoryFilterViewModel filters, CancellationToken cancellationToken);
    }
}
