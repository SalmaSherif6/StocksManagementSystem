using StocksManagementSystem.Domain.Entities;

namespace StocksManagementSystem.Services.Interfaces
{
    /// <summary>
    /// Represents the interface for the stock service.
    /// </summary>
    public interface IStockService
    {
        /// <summary>
        /// Gets an stock by its identifier.
        /// </summary>
        /// <param name="stockId">The identifier of the stock to retrieve.</param>
        /// <returns>The stock.</returns>
        Task<Stock> Get(int stockId);

        /// <summary>
        /// Gets all the stocks.
        /// </summary>
        /// <returns>The collection of stocks.</returns>
        Task<IEnumerable<Stock>> GetAll();
    }
}
