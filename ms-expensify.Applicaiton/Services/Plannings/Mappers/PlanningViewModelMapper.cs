using AutoMapper;
using ms_expensify.Application.Services.Plannings.ViewModels;
using ms_expensify.Domain.Entities;

namespace ms_expensify.Application.Services.Plannings.Mappers
{
    internal class PlanningViewModelMapper : Profile
    {
        public PlanningViewModelMapper()
        {
            CreateMap<Planning, PlanningViewModel>()
                .ForMember(dest => dest.TotalAmount, orig =>
                {
                    orig.PreCondition(ent => ent.Transactions.SelectMany(x => x.TransactionDetails) is not null && ent.Transactions.SelectMany(x => x.TransactionDetails).Any());
                    orig.MapFrom(ent => ent.Transactions.SelectMany(x => x.TransactionDetails).Sum(ele => ele.Amount));
                })
                ;
        }
    }
}
