using AutoMapper;
using ms_expensify.Application.Services.Transactions.ViewModels;
using ms_expensify.Domain.Entities;

namespace ms_expensify.Application.Services.Transactions.Mappers
{
    internal class TransactionPostViewModelMapper : Profile
    {
        public TransactionPostViewModelMapper()
        {
            CreateMap<TransactionPostViewModel, Transaction>()
                .ForMember(dest => dest.TotalAmount, orig => orig.MapFrom(ent => ent.TransactionDetails.Sum(x => x.Amount)))
                .ForMember(dest => dest.CreatedAt, orig => orig.MapFrom(ent => DateTime.Today))
                .ForMember(dest => dest.CreatedBy, orig => orig.MapFrom(ent => ent.UserId))
                .ForMember(dest => dest.LastModifiedAt, orig => orig.MapFrom(ent => DateTime.Today))
                .ForMember(dest => dest.LastModifiedBy, orig => orig.MapFrom(ent => ent.UserId))
                ;
        }
    }
}
