using Goof.Domain.Classes.ViewModels;

namespace ms_expensify.Application.Services.Currencies.ViewModels
{
    public class CurrencyViewModel : IdentifiableViewModel
    {
        public string Description { get; set; }
        public string Symbol { get; set; }
    }
}
