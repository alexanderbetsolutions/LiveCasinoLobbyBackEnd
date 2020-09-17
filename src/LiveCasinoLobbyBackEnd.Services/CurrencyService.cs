using LiveCasinoLobbyBackEnd.Contracts.Abstractions.Repositories;
using LiveCasinoLobbyBackEnd.Contracts.Abstractions.Services;
using LiveCasinoLobbyBackEnd.Contracts.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LiveCasinoLobbyBackEnd.Services
{
    public class CurrencyService : ICurrencyService
    {
        private readonly ICurrencyRepository repository;

        public CurrencyService(ICurrencyRepository repository)
        {
            this.repository = repository;
        }

        public Task<IEnumerable<CurrencyModel>> GetCurrenciesAsync()
        {
            return repository.GetCurrenciesAsync();
        }
    }
}