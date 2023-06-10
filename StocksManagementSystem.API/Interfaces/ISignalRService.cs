namespace StocksManagementSystem.API.Interfaces
{
    /// <summary>
    /// Interface for a SignalR service that handles sending stock price update notifications.
    /// </summary>
    public interface ISignalRService
    {
        /// <summary>
        /// Sends a stock price update notification to connected clients using SignalR.
        /// </summary>
        /// <returns></returns>
        Task SendStockPricesUpdateNotification();
    }
}
