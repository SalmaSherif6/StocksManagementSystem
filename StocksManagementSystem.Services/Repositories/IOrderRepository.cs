using StocksManagementSystem.Domain.Entities;

namespace StocksManagementSystem.Services.Repositories
{
    /// <summary>
    /// Represents the interface for the order repository.
    /// </summary>
    public interface IOrderRepository
    {
        /// <summary>
        /// Gets all the orders.
        /// </summary>
        /// <returns>The collection of orders.</returns>
        Task<IEnumerable<Order>> GetAll();

        /// <summary>
        /// Gets the order by its identifier.
        /// </summary>
        /// <param name="orderId">The identifier of the order.</param>
        /// <returns>The order.</returns>
        Task<Order> GetById(int orderId);

        /// <summary>
        /// Creates a new order.
        /// </summary>
        /// <param name="order">The order to create.</param>
        /// <returns>The created order.</returns>
        Task<Order> Create(Order order);

        /// <summary>
        /// Updates an existing order.
        /// </summary>
        /// <param name="order">The order to update.</param>
        /// <returns>The updated order.</returns>
        Task<Order> Update(Order order);

        /// <summary>
        /// Deletes an order by its identifier.
        /// </summary>
        /// <param name="orderId">The identifier of the order to delete.</param>
        Task DeleteOrder(int orderId);
    }
}
