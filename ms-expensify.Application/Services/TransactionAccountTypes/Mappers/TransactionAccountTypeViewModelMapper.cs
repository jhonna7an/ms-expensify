using AutoMapper;
using ms_expensify.Application.Services.TransactionAccountTypes.ViewModels;
using ms_expensify.Domain.Entities;

namespace ms_expensify.Application.Services.TransactionAccountTypes.Mappers
{
    internal class TransactionAccountTypeViewModelMapper : Profile
    {
        public TransactionAccountTypeViewModelMapper()
        {
            CreateMap<TransactionAccountType, TransactionAccountTypeViewModel>();
        }
    }
}
