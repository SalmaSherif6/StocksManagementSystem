using Microsoft.EntityFrameworkCore;
using StocksManagementSystem.Domain.Entities;
using StocksManagementSystem.Infrastucture.DbContexts;
using StocksManagementSystem.Services.Repositories;

namespace StocksManagementSystem.Infrastucture.Repositories
{
    /// <summary>
    /// Represents the repository for managing orders.
    /// </summary>
    public class OrderRepository : IOrderRepository
    {
        private DataContext _dataContext;

        /// <summary>
        /// Initializes a new instance of the <see cref="DataContext"/> class.
        /// </summary>
        /// <param name="dataContext"></param>
        public OrderRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        /// <summary>
        /// Gets all the orders.
        /// </summary>
        /// <returns>The collection of orders.</returns>
        public async Task<IEnumerable<Order>> GetAll()
        {
            return await Task.FromResult(_dataContext.Orders);
        }

        /// <summary>
        /// Gets the order by identifier.
        /// </summary>
        /// <param name="orderId">The order identifier.</param>
        /// <returns>The order.</returns>
        public async Task<Order> GetById(int orderId)
        {
            return await _dataContext.Orders.SingleAsync(o => o.Id == orderId);
        }

        /// <summary>
        /// Creates a new order.
        /// </summary>
        /// <param name="order">The order to create.</param>
        /// <returns>The created order.</returns>
        public async Task<Order> Create(Order order)
        {
            await _dataContext.Orders.AddAsync(order);
            await _dataContext.SaveChangesAsync();

            return order;
        }

        /// <summary>
        /// Updates an existing order.
        /// </summary>
        /// <param name="order">The order to update.</param>
        /// <returns>The updated order.</returns>
        public async Task<Order> Update(Order order)
        {
            _dataContext.Orders.Update(order);
            await _dataContext.SaveChangesAsync();

            return order;
        }

        /// <summary>
        /// Deletes an order by its identifier.
        /// </summary>
        /// <param name="orderId">The identifier of the order to delete.</param>
        /// <returns></returns>
        public async Task DeleteOrder(int orderId)
        {
            var order = await _dataContext.Orders.SingleAsync(o => o.Id == orderId);
            if (order != null)
            {
                _dataContext.Orders.Remove(order);
                await _dataContext.SaveChangesAsync();
            }
        }
    }
}
