using Microsoft.AspNetCore.Mvc;
using ms_expensify.Application.Services.TransactionCategories;
using ms_expensify.Application.Services.TransactionCategories.ViewModels;

namespace ms_expensify.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionCategoryController : ControllerBase
    {
        public readonly ITransactionCategoriesService _transactionCategoriesService;

        public TransactionCategoryController(ITransactionCategoriesService transactionCategoriesService)
        {
            _transactionCategoriesService = transactionCategoriesService;
        }

        [HttpGet]
        public async Task<IActionResult> GetByFilters([FromQuery] TransactionCategoryFilterViewModel filters, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var response = await _transactionCategoriesService.GetByFilters(filters, cancellationToken);
            return Ok(response);
        }
    }
}
