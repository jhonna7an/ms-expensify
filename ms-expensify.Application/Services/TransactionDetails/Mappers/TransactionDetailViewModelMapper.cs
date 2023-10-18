using AutoMapper;
using ms_expensify.Application.Services.TransactionDetails.ViewModels;
using ms_expensify.Domain.Entities;

namespace ms_expensify.Application.Services.TransactionDetails.Mappers
{
    internal class TransactionDetailViewModelMapper : Profile
    {
        public TransactionDetailViewModelMapper()
        {
            CreateMap<TransactionDetail, TransactionDetailViewModel>();
        }
    }
}
