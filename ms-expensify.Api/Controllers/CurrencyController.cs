using Microsoft.AspNetCore.Mvc;
using ms_expensify.Application.Services.Currencies;

namespace ms_expensify.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CurrencyController : ControllerBase
    {
        private readonly ICurrenciesService _currenciesService;

        public CurrencyController(ICurrenciesService currenciesService)
        {
            _currenciesService = currenciesService;
        }

        [HttpGet]
        public async Task<IActionResult> GetByFilters(CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var response = await _currenciesService.GetByFilters(cancellationToken);
            return Ok(response);
        }
    }
}
