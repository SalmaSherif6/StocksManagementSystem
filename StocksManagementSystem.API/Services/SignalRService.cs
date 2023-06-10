using StocksManagementSystem.API.Interfaces;

namespace StocksManagementSystem.API.Services
{
    /// <summary>
    /// Service class for sending stock price update notification using the hub service.
    /// </summary>
    public class SignalRService : ISignalRService
    {
        private readonly IHubService _hubService;

        public SignalRService(IHubService hubService)
        {
            _hubService = hubService;
        }

        /// <summary>
        /// Sends a stock price update notification using the underlying hub service.
        /// </summary>
        /// <returns></returns>
        public Task SendStockPricesUpdateNotification()
        {
            return _hubService.SendStockPricesUpdateNotification();
        }
    }
}
