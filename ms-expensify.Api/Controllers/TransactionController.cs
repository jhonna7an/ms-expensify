using Microsoft.AspNetCore.Mvc;
using ms_expensify.Application.Services.Transactions;
using ms_expensify.Application.Services.Transactions.ViewModels;

namespace ms_expensify.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly ITransactionsService _transactionsService;

        public TransactionController(ITransactionsService transactionsService)
        {
            _transactionsService = transactionsService;
        }

        [HttpGet("{id:int:min(1)}")]
        public async Task<IActionResult> GetById([FromRoute] int id, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var response = await _transactionsService.GetById(id, cancellationToken);
            return Ok(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetByFilters([FromQuery] TransactionFilterViewModel filters, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var response = await _transactionsService.GetByFilters(filters, cancellationToken);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Create(TransactionPostViewModel entityToAdd, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            string userId = HttpContext.Request.Headers["UserId"];
            entityToAdd.AddUser(int.Parse(userId));

            var response = await _transactionsService.Create(entityToAdd, cancellationToken);
            return Ok(response);
        }

        [HttpPatch("{id:int:min(1)}")]
        public async Task<IActionResult> Patch([FromRoute] int planningId, [FromBody] TransactionPatchViewModel entityToUpdate, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            string userId = HttpContext.Request.Headers["UserId"];
            entityToUpdate.AddUser(int.Parse(userId));

            var response = await _transactionsService.Patch(planningId, entityToUpdate, cancellationToken);
            return Ok(response);
        }

        [HttpDelete("{id:int:min(1)}")]
        public async Task<IActionResult> Delete([FromRoute] int id,  CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            await _transactionsService.Delete(id, cancellationToken);
            return NoContent();
        }
    }
}
