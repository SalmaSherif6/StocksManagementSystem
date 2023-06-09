using StocksManagementSystem.Domain.Entities;
using StocksManagementSystem.Services.Interfaces;
using StocksManagementSystem.Services.Repositories;

namespace StocksManagementSystem.Services.Services
{
    /// <summary>
    /// Represents the implementation of the order service.
    /// </summary>
    public class OrderService : IOrderService
    {
        private IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        /// <summary>
        /// Creates a new order.
        /// </summary>
        /// <param name="order">The order to create.</param>
        /// <returns>The created order.</returns>
        public Task<Order> Create(Order order)
        {
            return Task.FromResult(_orderRepository.Create(order));
        }

        /// <summary>
        /// Deletes an order by its identifier.
        /// </summary>
        /// <param name="orderId">The identifier of the order to delete.</param>
        public void Delete(int orderId)
        {
            _orderRepository.DeleteOrder(orderId);
        }

        /// <summary>
        /// Gets an order by its identifier.
        /// </summary>
        /// <param name="orderId">The identifier of the order.</param>
        /// <returns>The order.</returns>
        public Task<Order> Get(int orderId)
        {
            return Task.FromResult(_orderRepository.GetById(orderId));
        }

        /// <summary>
        /// Gets all the orders.
        /// </summary>
        /// <returns>The collection of orders.</returns>
        public Task<IEnumerable<Order>> GetAll()
        {
            return Task.FromResult(_orderRepository.GetAll());
        }

        /// <summary>
        /// Updates an existing order.
        /// </summary>
        /// <param name="order">The order to update.</param>
        /// <returns>The updated order.</returns>
        public Task<Order> Update(Order order)
        {
            var sourceOrder = _orderRepository.GetById(order.Id);

            sourceOrder.Quantity = order.Quantity;
            sourceOrder.Price = order.Price;
            sourceOrder.StockID = order.StockID;
            sourceOrder.PersonName = order.PersonName;

            return Task.FromResult(sourceOrder);
        }
    }
}
