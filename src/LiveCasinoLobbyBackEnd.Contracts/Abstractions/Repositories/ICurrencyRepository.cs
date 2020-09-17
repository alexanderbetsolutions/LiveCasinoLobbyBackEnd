using LiveCasinoLobbyBackEnd.Contracts.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LiveCasinoLobbyBackEnd.Contracts.Abstractions.Repositories
{
    public interface ICurrencyRepository
    {
        Task<IEnumerable<CurrencyModel>> GetCurrenciesAsync();
    }
}