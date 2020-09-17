using LiveCasinoLobbyBackEnd.Contracts.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LiveCasinoLobbyBackEnd.Contracts.Abstractions.Services
{
    public interface ICurrencyService
    {
        Task<IEnumerable<CurrencyModel>> GetCurrenciesAsync();
    }
}