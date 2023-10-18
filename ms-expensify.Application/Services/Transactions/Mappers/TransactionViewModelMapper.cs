using AutoMapper;
using ms_expensify.Application.Services.Transactions.ViewModels;
using ms_expensify.Domain.Entities;

namespace ms_expensify.Application.Services.Transactions.Mappers
{
    internal class TransactionViewModelMapper : Profile
    {
        public TransactionViewModelMapper()
        {
            CreateMap<Transaction, TransactionViewModel>()
                .ForMember(dest => dest.TotalAmount, orig => orig.MapFrom(ent => ent.TransactionDetails.Sum(x => x.Amount)))
                ;
        }
    }
}
