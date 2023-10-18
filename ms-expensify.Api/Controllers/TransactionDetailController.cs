using Microsoft.AspNetCore.Mvc;
using ms_expensify.Application.Services.TransactionDetails;
using ms_expensify.Application.Services.TransactionDetails.ViewModels;

namespace ms_expensify.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionDetailController : ControllerBase
    {
        private readonly ITransactionDetailsService _transactionDetailsService;

        public TransactionDetailController(ITransactionDetailsService transactionDetailsService)
        {
            _transactionDetailsService = transactionDetailsService;
        }

        [HttpPost("{transactionId:int:min(1)}")]
        public async Task<IActionResult> Create([FromRoute] int transactionId,[FromBody] TransactionDetailPostViewModel entityToAdd, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            string userId = HttpContext.Request.Headers["UserId"];
            entityToAdd.AddUser(int.Parse(userId));

            var response = await _transactionDetailsService.Create(transactionId, entityToAdd, cancellationToken);
            return Ok(response);
        }

        [HttpPatch("{id:int:min(1)}")]
        public async Task<IActionResult> Patch([FromRoute] int id, [FromBody] TransactionDetailPatchViewModel entityToUpdate, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            string userId = HttpContext.Request.Headers["UserId"];
            entityToUpdate.AddUser(int.Parse(userId));

            var response = await _transactionDetailsService.Patch(id, entityToUpdate, cancellationToken);
            return Ok(response);
        }

        [HttpDelete("{id:int:min(1)}")]
        public async Task<IActionResult> Delete([FromRoute] int id, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            await _transactionDetailsService.Delete(id, cancellationToken);
            return NoContent();
        }
    }
}
