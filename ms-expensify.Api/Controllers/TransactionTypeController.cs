using Microsoft.AspNetCore.Mvc;
using ms_expensify.Application.Services.TransactionTypes;

namespace ms_expensify.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionTypeController : ControllerBase
    {
        private readonly ITransactionTypesService _transactionTypesService;

        public TransactionTypeController(ITransactionTypesService transactionTypesService)
        {
            _transactionTypesService = transactionTypesService;
        }

        [HttpGet]
        public async Task<IActionResult> GetByFilters(CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var response = await _transactionTypesService.GetByFilters(cancellationToken);
            return Ok(response);
        }
    }
}
