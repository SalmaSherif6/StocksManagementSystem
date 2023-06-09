using StocksManagementSystem.Domain.Entities;
using StocksManagementSystem.Infrastucture.DbContexts;

namespace StocksManagementSystem.Infrastucture.Repositories
{
    /// <summary>
    /// Represents the repository for managing stocks.
    /// </summary>
    public class StockRepository
    {
        private DataContext _dataContext;

        /// <summary>
        /// Initializes a new instance of the <see cref="DataContext"/> class.
        /// </summary>
        /// <param name="dataContext"></param>
        public StockRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        /// <summary>
        /// Gets all the stocks.
        /// </summary>
        /// <returns>The collection of stocks.</returns>
        public IEnumerable<Stock> GetAll()
        {
            return _dataContext.Stocks;
        }

        /// <summary>
        /// Gets the stock by identifier.
        /// </summary>
        /// <param name="stockId">The stock identifier.</param>
        /// <returns>The stock.</returns>
        public Stock GetById(int stockId)
        {
            return _dataContext.Stocks.Single(s => s.Id == stockId);
        }
    }
}
