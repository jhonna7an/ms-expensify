using Microsoft.AspNetCore.Mvc;
using ms_expensify.Application.Services.TransactionAmountTypes;

namespace ms_expensify.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionAmountTypeController : ControllerBase
    {
        private readonly ITransactionAmountTypesService _transactionAmountTypesService;

        public TransactionAmountTypeController(ITransactionAmountTypesService transactionAmountTypesService)
        {
            _transactionAmountTypesService = transactionAmountTypesService;
        }

        [HttpGet]
        public async Task<IActionResult> GetByFilters(CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var response = await _transactionAmountTypesService.GetByFilters(cancellationToken);
            return Ok(response);
        }
    }
}
