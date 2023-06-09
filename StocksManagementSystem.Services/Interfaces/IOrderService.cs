using StocksManagementSystem.Domain.Entities;

namespace StocksManagementSystem.Services.Interfaces
{
    /// <summary>
    /// Represents the interface for the order service.
    /// </summary>
    public interface IOrderService
    {
        /// <summary>
        /// Updates an existing order.
        /// </summary>
        /// <param name="order">The order to update.</param>
        /// <returns>The updated order.</returns>
        Task<Order> Update(Order order);

        /// <summary>
        /// Creates a new order.
        /// </summary>
        /// <param name="order">The order to create.</param>
        /// <returns>The created order.</returns>
        Task<Order> Create(Order order);

        /// <summary>
        /// Deletes an order by its identifier.
        /// </summary>
        /// <param name="orderId">The identifier of the order to delete.</param>
        void Delete(int orderId);

        /// <summary>
        /// Gets an order by its identifier.
        /// </summary>
        /// <param name="orderId">The identifier of the order to retrieve.</param>
        /// <returns>The order.</returns>
        Task<Order> Get(int orderId);

        /// <summary>
        /// Gets all the orders.
        /// </summary>
        /// <returns>The collection of orders.</returns>
        Task<IEnumerable<Order>> GetAll();
    }
}
