using StocksManagementSystem.Domain.Entities;

namespace StocksManagementSystem.Services.Repositories
{
    /// <summary>
    /// Represents the interface for the stock repository.
    /// </summary>
    public interface IStockRepository
    {
        /// <summary>
        /// Gets all the stocks.
        /// </summary>
        /// <returns>The collection of stocks.</returns>
        Task<IEnumerable<Stock>> GetAll();

        /// <summary>
        /// Gets the stock by its identifier.
        /// </summary>
        /// <param name="stockId">The identifier of the stock.</param>
        /// <returns>The stock.</returns>
        Task<Stock> GetById(int stockId);

        /// <summary>
        /// Shuffles the prices of stocks in the database.
        /// </summary>
        /// <returns></returns>
        Task ShufflePrices();
    }
}
