using CurrencyService;

namespace LiveCasinoLobbyBackEnd.Repositories
{
    public interface IRemoteServiceClientFactory
    {
        CurrencyServiceClient GetCurrencyServiceClient();
    }
}