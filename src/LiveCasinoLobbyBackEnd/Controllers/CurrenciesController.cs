using LiveCasinoLobbyBackEnd.Contracts.Abstractions.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LiveCasinoLobbyBackEnd.Controllers
{
    public class CurrenciesController : BaseController
    {
        private readonly ICurrencyService currencyService;

        public CurrenciesController(ICurrencyService currencyService)
        {
            this.currencyService = currencyService;
        }

        public async Task<IActionResult> Get()
        {
            var currencies = await currencyService.GetCurrenciesAsync();

            return Ok(currencies);
        }
    }
}