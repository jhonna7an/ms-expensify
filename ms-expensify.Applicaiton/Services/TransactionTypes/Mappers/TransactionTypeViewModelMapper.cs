using AutoMapper;
using ms_expensify.Application.Services.TransactionTypes.ViewModels;
using ms_expensify.Domain.Entities;

namespace ms_expensify.Application.Services.TransactionTypes.Mappers
{
    public class TransactionTypeViewModelMapper : Profile
    {
        public TransactionTypeViewModelMapper()
        {
            CreateMap<TransactionType, TransactionTypeViewModel>();
        }
    }
}
