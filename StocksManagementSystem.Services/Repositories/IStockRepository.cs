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
        IEnumerable<Stock> GetAll();

        /// <summary>
        /// Gets the stock by its identifier.
        /// </summary>
        /// <param name="stockId">The identifier of the stock.</param>
        /// <returns>The stock.</returns>
        Stock GetById(int stockId);
    }
}
