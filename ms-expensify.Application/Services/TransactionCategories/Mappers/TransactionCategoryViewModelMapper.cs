using AutoMapper;
using ms_expensify.Application.Services.TransactionCategories.ViewModels;
using ms_expensify.Domain.Entities;

namespace ms_expensify.Application.Services.TransactionCategories.Mappers
{
    internal class TransactionCategoryViewModelMapper : Profile
    {
        public TransactionCategoryViewModelMapper()
        {
            CreateMap<TransactionCategory, TransactionCategoryViewModel>();
        }
    }
}
