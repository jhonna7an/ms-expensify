using Microsoft.AspNetCore.Mvc;
using ms_expensify.Application.Services.Plannings;
using ms_expensify.Application.Services.Plannings.ViewModels;

namespace ms_expensify.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlanningController : ControllerBase
    {
        private readonly IPlanningsService _planningsService;

        public PlanningController(IPlanningsService planningsService)
        {
            _planningsService = planningsService;
        }

        [HttpGet("{id:int:min(1)}")]
        public async Task<IActionResult> GetById([FromRoute] int id, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var response = await _planningsService.GetById(id, cancellationToken);
            return Ok(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetByFilters([FromQuery] PlanningFilterViewModel filters, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var response = await _planningsService.GetByFilters(filters, cancellationToken);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Create(PlanningPostViewModel entityToAdd, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            string userId = HttpContext.Request.Headers["UserId"];
            entityToAdd.AddUser(int.Parse(userId));

            var response = await _planningsService.Create(entityToAdd, cancellationToken);
            return Ok(response);
        }

        [HttpPatch("{id:int:min(1)}")]
        public async Task<IActionResult> Patch([FromRoute] int id, [FromBody] PlanningPatchViewModel entityToUpdate, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            string userId = HttpContext.Request.Headers["UserId"];
            entityToUpdate.AddUser(int.Parse(userId));

            var response = await _planningsService.Patch(id, entityToUpdate, cancellationToken);
            return Ok(response);
        }

        [HttpPatch("{id:int:min(1)}/Transaction")]
        public async Task<IActionResult> PatchByPlanning([FromRoute] int id, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            string userId = HttpContext.Request.Headers["UserId"];

            await _planningsService.PatchByTransactions(id, int.Parse(userId), cancellationToken);
            return NoContent();
        }

        [HttpDelete("{id:int:min(1)}")]
        public async Task<IActionResult> Delete([FromRoute] int id, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            await _planningsService.Delete(id, cancellationToken);
            return NoContent();
        }
    }
}
