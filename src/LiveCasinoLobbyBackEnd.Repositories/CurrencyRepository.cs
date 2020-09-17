using LiveCasinoLobbyBackEnd.Contracts.Abstractions.Repositories;
using LiveCasinoLobbyBackEnd.Contracts.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LiveCasinoLobbyBackEnd.Repositories
{
    public class CurrencyRepository : ICurrencyRepository
    {
        private readonly IRemoteServiceClientFactory serviceClientFactory;

        public CurrencyRepository(IRemoteServiceClientFactory remoteServiceClientFactory)
        {
            serviceClientFactory = remoteServiceClientFactory;
        }

        public async Task<IEnumerable<CurrencyModel>> GetCurrenciesAsync()
        {
            var serviceClient = serviceClientFactory.GetCurrencyServiceClient();

            var currencies = await serviceClient.GetCurrenciesAsync();

            return currencies.Select(x => new CurrencyModel
            {
                Code = x.Code,
                Symbol = x.Symbol
            });
        }
    }
}