using StocksManagementSystem.API.Hubs;
using StocksManagementSystem.API.Interfaces;
using Microsoft.AspNetCore.SignalR;

namespace StocksManagementSystem.API.Services
{
    /// <summary>
    /// Service class for sending stock price update notification using SignalR.
    /// </summary>
    public class HubService : IHubService
    {
        private readonly IHubContext<NotificationHub> _hubContext;

        public HubService(IHubContext<NotificationHub> hubContext)
        {
            _hubContext = hubContext;
        }

        /// <summary>
        /// Sends a stock price update notification to all connected clients using SignalR.
        /// </summary>
        /// <returns></returns>
        public async Task SendStockPricesUpdateNotification()
        {
            await _hubContext.Clients.All.SendAsync("PricesUpdate");
        }
    }
}
