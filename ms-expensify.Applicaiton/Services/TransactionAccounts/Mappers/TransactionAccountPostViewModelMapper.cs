using AutoMapper;
using ms_expensify.Application.Services.TransactionAccounts.ViewModels;
using ms_expensify.Domain.Entities;

namespace ms_expensify.Application.Services.TransactionAccounts.Mappings
{
    public class TransactionAccountPostViewModelMapper : Profile
    {
        public TransactionAccountPostViewModelMapper()
        {
            CreateMap<TransactionAccountPostViewModel, TransactionAccount>()
                .ForMember(dest => dest.CreatedAt, orig => orig.MapFrom(ent => DateTime.Today))
                .ForMember(dest => dest.CreatedBy, orig => orig.MapFrom(ent => ent.UserId))
                .ForMember(dest => dest.LastModifiedAt, orig => orig.MapFrom(ent => DateTime.Today))
                .ForMember(dest => dest.LastModifiedBy, orig => orig.MapFrom(ent => ent.UserId))
                ;
        }
    }
}
