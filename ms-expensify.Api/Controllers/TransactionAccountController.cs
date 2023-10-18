using Microsoft.AspNetCore.Mvc;
using ms_expensify.Application.Services.TransactionAccounts;
using ms_expensify.Application.Services.TransactionAccounts.ViewModels;

namespace ms_expensify.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionAccountController : ControllerBase
    {
        private readonly ITransactionAccountsService _tranasctionAccountsService;

        public TransactionAccountController(ITransactionAccountsService tranasctionAccountsService)
        {
            _tranasctionAccountsService = tranasctionAccountsService;
        }

        [HttpGet("{id:int:min(1)}")]
        public async Task<IActionResult> GetById([FromRoute] int number, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var response = await _tranasctionAccountsService.GetById(number, cancellationToken);
            return Ok(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetByFilters([FromQuery] TransactionAccountFilterViewModel filters, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var response = await _tranasctionAccountsService.GetByFilters(filters, cancellationToken);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] TransactionAccountPostViewModel entityToAdd, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            string userId = HttpContext.Request.Headers["UserId"];
            entityToAdd.AddUser(int.Parse(userId));

            var response = await _tranasctionAccountsService.Create(entityToAdd, cancellationToken);
            return Ok(response);
        }

        [HttpPatch("{id:int:min(1)}")]
        public async Task<IActionResult> Patch([FromRoute] int id,[FromBody] TransactionAccountPatchViewModel entityToUpdate, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            string userId = HttpContext.Request.Headers["UserId"];
            entityToUpdate.AddUser(int.Parse(userId));

            var response = await _tranasctionAccountsService.Patch(id, entityToUpdate, cancellationToken);
            return Ok(response);
        }

        [HttpDelete("{id:int:min(1)}")]
        public async Task<IActionResult> Detelete([FromRoute] int id, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            await _tranasctionAccountsService.Delete(id, cancellationToken);
            return NoContent();
        }
    }
}
