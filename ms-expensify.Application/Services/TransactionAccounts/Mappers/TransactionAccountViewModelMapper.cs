using AutoMapper;
using ms_expensify.Application.Services.TransactionAccounts.ViewModels;
using ms_expensify.Domain.Entities;

namespace ms_expensify.Application.Services.TransactionAccounts.Mappings
{
    internal class TransactionAccountViewModelMapper : Profile
    {
        public TransactionAccountViewModelMapper()
        {
            CreateMap<TransactionAccount, TransactionAccountViewModel>()
                .ForMember(dest => dest.TotalAmount, orig => orig.MapFrom(ent => Math.Round(ent.InitialAmount, 2)))
                .ForMember(dest => dest.CurrencyAbbreviation, orig => orig.MapFrom(ent => ent.Currency.Symbol));
        }
    }
}
