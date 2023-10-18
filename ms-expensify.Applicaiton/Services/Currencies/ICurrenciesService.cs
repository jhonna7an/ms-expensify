using ms_expensify.Application.Services.Currencies.ViewModels;

namespace ms_expensify.Application.Services.Currencies
{
    public interface ICurrenciesService
    {
        Task<List<CurrencyViewModel>> GetByFilters(CancellationToken cancellationToken);
    }
}
