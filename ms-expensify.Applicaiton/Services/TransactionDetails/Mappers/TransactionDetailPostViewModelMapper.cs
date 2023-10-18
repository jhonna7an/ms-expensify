using AutoMapper;
using ms_expensify.Application.Services.TransactionDetails.ViewModels;
using ms_expensify.Domain.Entities;

namespace ms_expensify.Application.Services.TransactionDetails.Mappers
{
    internal class TransactionDetailPostViewModelMapper : Profile
    {
        public TransactionDetailPostViewModelMapper()
        {
            CreateMap<TransactionDetailPostViewModel, TransactionDetail>()
                .ForMember(dest => dest.CreatedAt, orig => orig.MapFrom(ent => DateTime.Today))
                .ForMember(dest => dest.CreatedBy, orig => orig.MapFrom(ent => ent.UserId))
                .ForMember(dest => dest.LastModifiedAt, orig => orig.MapFrom(ent => DateTime.Today))
                .ForMember(dest => dest.LastModifiedBy, orig => orig.MapFrom(ent => ent.UserId))
                ;
        }
    }
}
