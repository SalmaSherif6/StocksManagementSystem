using Microsoft.EntityFrameworkCore;
using StocksManagementSystem.Domain.Entities;
using StocksManagementSystem.Infrastucture.DbContexts;
using StocksManagementSystem.Services.Repositories;

namespace StocksManagementSystem.Infrastucture.Repositories
{
    /// <summary>
    /// Represents the repository for managing stocks.
    /// </summary>
    public class StockRepository : IStockRepository
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
        public async Task<IEnumerable<Stock>> GetAll()
        {
            return await Task.FromResult(_dataContext.Stocks);
        }

        /// <summary>
        /// Gets the stock by identifier.
        /// </summary>
        /// <param name="stockId">The stock identifier.</param>
        /// <returns>The stock.</returns>
        public async Task<Stock> GetById(int stockId)
        {
            return await _dataContext.Stocks.SingleAsync(s => s.Id == stockId);
        }

        /// <summary>
        /// Shuffles the prices of stocks in the database.
        /// </summary>
        /// <returns></returns>
        public async Task ShufflePrices()
        {
            var rnd = new Random();

            var stocks = await _dataContext.Stocks.ToListAsync();
            stocks.ForEach(s =>
            {
                s.Price = rnd.Next(1, 101);
            });

            await _dataContext.SaveChangesAsync();
        }
    }
}
