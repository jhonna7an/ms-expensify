using AutoMapper;
using ms_expensify.Application.Services.Transactions.ViewModels;
using ms_expensify.Domain.Entities;

namespace ms_expensify.Application.Services.Transactions.Mappers
{
    public class TransactionPatchViewModelMapper : Profile
    {
        public TransactionPatchViewModelMapper()
        {
            CreateMap<TransactionPatchViewModel, Transaction>()
                .ForMember(dest => dest.LastModifiedAt, orig => orig.MapFrom(ent => DateTime.Today))
                .ForMember(dest => dest.LastModifiedBy, orig => orig.MapFrom(ent => ent.UserId))
                .ForMember(dest => dest.TransactionCategoryId, orig =>
                {
                    orig.PreCondition(ent => ent.TransactionCategoryId.HasValue);
                    orig.MapFrom(ent => ent.TransactionCategoryId!.Value);
                })
                .ForMember(dest => dest.TransactionStateId, orig =>
                {
                    orig.PreCondition(ent => ent.TransactionStateId.HasValue);
                    orig.MapFrom(ent => ent.TransactionStateId!.Value);
                })
                .ForMember(dest => dest.Description, orig =>
                {
                    orig.PreCondition(ent => !string.IsNullOrEmpty(ent.Description));
                    orig.MapFrom(ent => ent.Description);
                })
                ;
        }
    }
}
