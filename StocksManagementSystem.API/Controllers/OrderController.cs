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

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Order>>> GetAllOrders()
        {
            var orders = await _orderService.GetAll();

            return Ok(orders);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Order>> GetOrderById(int id)
        {
            var order = await _orderService.Get(id);

            return Ok(order);
        }

        [HttpPost]
        public async Task<ActionResult<Order>> CreateOrder(Order order)
        {
            var createdOrder = await _orderService.Create(order);

            return Ok(createdOrder);
        }

        [HttpPut]
        public async Task<ActionResult<Order>> UpdateOrder(Order newOrder)
        {
            var updatedOrder = await _orderService.Update(newOrder);

            return Ok(updatedOrder);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteOrder(int id)
        {
            await _orderService.Delete(id);

            return Ok();
        }
    }
}
