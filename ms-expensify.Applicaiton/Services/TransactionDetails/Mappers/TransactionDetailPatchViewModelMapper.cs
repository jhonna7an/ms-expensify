using AutoMapper;
using ms_expensify.Application.Services.TransactionDetails.ViewModels;
using ms_expensify.Domain.Entities;

namespace ms_expensify.Application.Services.TransactionDetails.Mappers
{
    internal class TransactionDetailPatchViewModelMapper : Profile
    {
        public TransactionDetailPatchViewModelMapper()
        {
            CreateMap<TransactionDetailPatchViewModel, TransactionDetail>()
                .ForMember(dest => dest.LastModifiedAt, orig => orig.MapFrom(ent => DateTime.Today))
                .ForMember(dest => dest.LastModifiedBy, orig => orig.MapFrom(ent => ent.UserId))
                .ForMember(dest => dest.TransactionAmountTypeId, orig =>
                {
                    orig.PreCondition(ent => ent.TransactionAmountTypeId.HasValue);
                    orig.MapFrom(ent => ent.TransactionAmountTypeId!.Value);
                })
                .ForMember(dest => dest.Date, orig =>
                {
                    orig.PreCondition(ent => ent.Date.HasValue);
                    orig.MapFrom(ent => ent.Date!.Value);
                })
                .ForMember(dest => dest.Amount, orig =>
                {
                    orig.PreCondition(ent => ent.Amount.HasValue);
                    orig.MapFrom(ent => ent.Amount!.Value);
                })
                ;
        }
    }
}
