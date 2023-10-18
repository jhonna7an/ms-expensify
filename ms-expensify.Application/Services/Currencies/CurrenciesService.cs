 using ms_expensify.Application.Contracts.Repositories;
using ms_expensify.Application.Services.Currencies.ViewModels;
using ms_expensify.Domain.Entities;

namespace ms_expensify.Application.Services.Currencies
{
    public class CurrenciesService : ICurrenciesService
    {
        private readonly ICurrenciesRepository _currencyRepository;

        public CurrenciesService(ICurrenciesRepository currencyRepository)
        {
            _currencyRepository = currencyRepository;
        }

        public async Task<List<CurrencyViewModel>> GetByFilters(CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            List<Currency> currencies = _currencyRepository.GetByFilters(x => x)
                .ToList();

            return currencies.Select(x => new CurrencyViewModel
            {
                Id = x.Id,
                Description = x.Description,
                Symbol = x.Symbol
            }).ToList();
        } 
    }
}
