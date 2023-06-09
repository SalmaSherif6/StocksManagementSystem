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
        public ActionResult<IEnumerable<Order>> GetAllOrders()
        {
            var orders = _orderService.GetAll();

            return Ok(orders);
        }

        [HttpGet("{id}")]
        public ActionResult<Order> GetOrderById(int id)
        {
            var order = _orderService.Get(id);

            return Ok(order);
        }

        [HttpPost]
        public ActionResult<Order> CreateOrder(Order order)
        {
            _orderService.Create(order);

            return Ok(order);
        }

        [HttpPut]
        public ActionResult<Order> UpdateOrder(Order newOrder)
        {
            var order = _orderService.Update(newOrder);

            return Ok(order);
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteOrder(int id)
        {
            _orderService.Delete(id);

            return Ok();
        }
    }
}
