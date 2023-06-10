using Microsoft.EntityFrameworkCore;
using StocksManagementSystem.Domain.Entities;

namespace StocksManagementSystem.Infrastucture.DbContexts
{
    /// <summary>
    /// Represents the data context for managing stocks and orders.
    /// </summary>
    public class DataContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of <see cref="DataContext"/> class.
        /// </summary>
        /// <param name="options">The options for configuring the data context.</param>
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        /// <summary>
        /// Gets or sets the stocks in the system.
        /// </summary>
        public DbSet<Stock> Stocks { get; set; }

        /// <summary>
        /// Gets or sets the orders in the system.
        /// </summary>
        public DbSet<Order> Orders { get; set; }
    }
}
