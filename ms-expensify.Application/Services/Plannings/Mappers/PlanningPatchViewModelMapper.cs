using AutoMapper;
using ms_expensify.Application.Services.Plannings.ViewModels;
using ms_expensify.Domain.Entities;

namespace ms_expensify.Application.Services.Plannings.Mappers
{
    public class PlanningPatchViewModelMapper : Profile
    {
        public PlanningPatchViewModelMapper()
        {
            CreateMap<PlanningPatchViewModel, Planning>()
                .ForMember(dest => dest.LastModifiedAt, orig => orig.MapFrom(ent => DateTime.Today))
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
                .ForMember(dest => dest.Date, orig =>
                {
                    orig.PreCondition(ent => ent.Date.HasValue);
                    orig.MapFrom(ent => ent.Date);
                })
                ;
        }
    }
}
