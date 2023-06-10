namespace StocksManagementSystem.API.Interfaces
{
    /// <summary>
    /// Interface for a hub service that handles sending stock price update notifications.
    /// </summary>
    public interface IHubService
    {
        /// <summary>
        /// Sends a stock price update notification to connected clients.
        /// </summary>
        /// <returns></returns>
        Task SendStockPricesUpdateNotification();
    }
}
