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
        public IEnumerable<Order> GetAll()
        {
            return _dataContext.Orders;
        }

        /// <summary>
        /// Gets the order by identifier.
        /// </summary>
        /// <param name="orderId">The order identifier.</param>
        /// <returns>The order.</returns>
        public Order GetById(int orderId)
        {
            return _dataContext.Orders.Single(o => o.Id == orderId);
        }

        /// <summary>
        /// Creates a new order.
        /// </summary>
        /// <param name="order">The order to create.</param>
        /// <returns>The created order.</returns>
        public Order Create(Order order)
        {
            _dataContext.Orders.Add(order);
            return order;
        }

        /// <summary>
        /// Updates an existing order.
        /// </summary>
        /// <param name="order">The order to update.</param>
        /// <returns>The updated order.</returns>
        public Order Update(Order order)
        {
            _dataContext.Orders.Update(order);
            return order;
        }

        /// <summary>
        /// Deletes an order by its identifier.
        /// </summary>
        /// <param name="orderId">The identifier of the order to delete.</param>
        /// <returns></returns>
        public void DeleteOrder(int orderId)
        {
            var order = _dataContext.Orders.Single(o => o.Id == orderId);

            _dataContext.Orders.Remove(order);
        }
    }
}
