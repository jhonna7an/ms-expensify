using AutoMapper;
using ms_expensify.Application.Services.TransactionAmountTypes.ViewModels;
using ms_expensify.Domain.Entities;

namespace ms_expensify.Application.Services.TransactionAmountTypes.Mappers
{
    internal class TransactionAmountTypeViewModelMapper : Profile
    {
        public TransactionAmountTypeViewModelMapper()
        {
            CreateMap<TransactionAmountType, TransactionAmountTypeViewModel>();
        }
    }
}
