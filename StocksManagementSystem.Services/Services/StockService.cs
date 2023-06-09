using StocksManagementSystem.Domain.Entities;
using StocksManagementSystem.Services.Interfaces;
using StocksManagementSystem.Services.Repositories;

namespace StocksManagementSystem.Services.Services
{
    /// <summary>
    /// Represents the implementation of the stock service.
    /// </summary>
    public class StockService : IStockService
    {
        private IStockRepository _stockRepository;

        public StockService(IStockRepository stockRepository)
        {
            _stockRepository = stockRepository;
        }

        /// <summary>
        /// Gets a stock by its identifier.
        /// </summary>
        /// <param name="stockId">The identifier of the stock.</param>
        /// <returns>The stock.</returns>
        public Task<Stock> Get(int stockId)
        {
            return Task.FromResult(_stockRepository.GetById(stockId));
        }

        /// <summary>
        /// Gets all the stocks.
        /// </summary>
        /// <returns>The collection of stocks.</returns>
        public Task<IEnumerable<Stock>> GetAll()
        {
            return Task.FromResult(_stockRepository.GetAll());
        }
    }
}
