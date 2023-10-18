using AutoMapper;
using ms_expensify.Application.Services.Plannings.ViewModels;
using ms_expensify.Domain.Entities;

namespace ms_expensify.Application.Services.Plannings.Mappers
{
    internal class PlanningPostViewModelMapper : Profile
    {
        public PlanningPostViewModelMapper()
        {
            CreateMap<PlanningPostViewModel, Planning>()
                .ForMember(dest => dest.CreatedAt, orig => orig.MapFrom(ent => DateTime.Today))
                .ForMember(dest => dest.CreatedBy, orig => orig.MapFrom(ent => ent.UserId))
                .ForMember(dest => dest.LastModifiedAt, orig => orig.MapFrom(ent => DateTime.Today))
                .ForMember(dest => dest.LastModifiedBy, orig => orig.MapFrom(ent => ent.UserId))
                ;
        }
    }
}
