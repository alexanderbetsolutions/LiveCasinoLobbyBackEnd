using CurrencyService;
using Microsoft.Extensions.Configuration;
using System.ServiceModel;

namespace LiveCasinoLobbyBackEnd.Repositories
{
    public class RemoteServiceClientFactory : IRemoteServiceClientFactory
    {
        private readonly IConfiguration configuration;

        public RemoteServiceClientFactory(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public CurrencyServiceClient GetCurrencyServiceClient()
        {
            return new CurrencyServiceClient(
                new BasicHttpBinding(),
                new EndpointAddress($"{configuration["databaseServiceBaseUrl"]}CurrencyService.svc"));
        }
    }
}