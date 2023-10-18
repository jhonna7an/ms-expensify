using Microsoft.AspNetCore.Mvc;
using ms_expensify.Application.Services.TransactionAccountTypes;

namespace ms_expensify.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionAccountTypeController : ControllerBase
    {
        private readonly ITransactionAccountTypesService _transactionAccountTypesService;

        public TransactionAccountTypeController(ITransactionAccountTypesService transactionAccountTypesService)
        {
            _transactionAccountTypesService = transactionAccountTypesService;
        }

        [HttpGet]
        public async Task<IActionResult> GetBYFilters(CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var response = await _transactionAccountTypesService.GetByFilters(cancellationToken);
            return Ok(response); 
        }
    }
}
