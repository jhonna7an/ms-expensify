using AutoMapper;
using ms_expensify.Application.Services.TransactionAccounts.ViewModels;
using ms_expensify.Domain.Entities;

namespace ms_expensify.Application.Services.TransactionAccounts.Mappings
{
    public class TransactionAccountPatchViewModelMapper : Profile
    {
        public TransactionAccountPatchViewModelMapper()
        {
            CreateMap<TransactionAccountPatchViewModel, TransactionAccount>()
                .ForMember(dest => dest.LastModifiedAt, orig => orig.MapFrom(ent => DateTime.UtcNow))
                .ForMember(dest => dest.LastModifiedBy, orig => orig.MapFrom(ent => ent.UserId))
                .ForMember(dest => dest.Name, orig =>
                {
                    orig.PreCondition(ent => !string.IsNullOrEmpty(ent.Name));
                    orig.MapFrom(ent => ent.Name);
                })
                .ForMember(dest => dest.Description, orig =>
                {
                    orig.PreCondition(ent => !string.IsNullOrEmpty(ent.Description));
                    orig.MapFrom(ent => ent.Description);
                })
                .ForMember(dest => dest.CurrencyId, orig =>
                {
                    orig.PreCondition(ent => ent.CurrencyId.HasValue);
                    orig.MapFrom(ent => ent.CurrencyId);
                })
                .ForMember(dest => dest.HideBalance, orig =>
                {
                    orig.PreCondition(ent => ent.HideBalance.HasValue);
                    orig.MapFrom(ent => ent.HideBalance);
                })
                .ForMember(dest => dest.InitialAmount, orig =>
                {
                    orig.PreCondition(ent => ent.Amount.HasValue);
                    orig.MapFrom(ent => ent.Amount);
                })
                .ForMember(dest => dest.IconLink, orig =>
                {
                    orig.PreCondition(ent => !string.IsNullOrEmpty(ent.IconLink));
                    orig.MapFrom(ent => ent.IconLink);
                })
                .ForMember(dest => dest.ColorPicked, orig =>
                {
                    orig.PreCondition(ent => !string.IsNullOrEmpty(ent.ColorPicked));
                    orig.MapFrom(ent => ent.ColorPicked);
                })
                ;
        }
    }
}
