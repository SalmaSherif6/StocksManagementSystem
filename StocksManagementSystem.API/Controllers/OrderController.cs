using Microsoft.AspNetCore.Mvc;
using StocksManagementSystem.Domain.Entities;
using StocksManagementSystem.Services.Interfaces;

namespace StocksManagementSystem.API.Controllers
{
    [Route("api/orders")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        /// <summary>
        /// Retrieves all orders.
        /// </summary>
        /// <returns>The collection of orders.</returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Order>>> GetAllOrders()
        {
            var orders = await _orderService.GetAll();

            return Ok(orders);
        }

        /// <summary>
        /// Retrieves an order by its identifier.
        /// </summary>
        /// <param name="id">The identifier of the order.</param>
        /// <returns>The order.</returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<Order>> GetOrderById(int id)
        {
            var order = await _orderService.Get(id);

            return Ok(order);
        }

        /// <summary>
        /// Creates a new order.
        /// </summary>
        /// <param name="order">The order to create.</param>
        /// <returns>The created order.</returns>
        [HttpPost]
        public async Task<ActionResult<Order>> CreateOrder(Order order)
        {
            var createdOrder = await _orderService.Create(order);

            return Ok(createdOrder);
        }

        /// <summary>
        /// Updates an existing order.
        /// </summary>
        /// <param name="newOrder">The updated order.</param>
        /// <returns>The updated order.</returns>
        [HttpPut]
        public async Task<ActionResult<Order>> UpdateOrder(Order newOrder)
        {
            var updatedOrder = await _orderService.Update(newOrder);

            return Ok(updatedOrder);
        }

        /// <summary>
        /// Deletes an order by its identifier.
        /// </summary>
        /// <param name="id">The identifier of the order to be delete.</param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteOrder(int id)
        {
            await _orderService.Delete(id);

            return Ok();
        }
    }
}
