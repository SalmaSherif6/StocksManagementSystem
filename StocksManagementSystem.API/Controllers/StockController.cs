using Microsoft.AspNetCore.Mvc;
using StocksManagementSystem.Domain.Entities;
using StocksManagementSystem.Services.Interfaces;

namespace StocksManagementSystem.API.Controllers
{
    [Route("api/stocks")]
    [ApiController]
    public class StockController : ControllerBase
    {
        private IStockService _stockService;

        public StockController(IStockService stockService)
        {
            _stockService = stockService;
        }

        /// <summary>
        /// Retrieves all stocks.
        /// </summary>
        /// <returns>The collection of stocks.</returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Stock>>> GetAllStocks()
        {
            var stocks = await _stockService.GetAll();

            return Ok(stocks);
        }

        /// <summary>
        /// Retrieves a stock by its identifier.
        /// </summary>
        /// <param name="id">The identifier of the stock.</param>
        /// <returns>The stock.</returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<Stock>> GetStockById(int id)
        {
            var stock = await _stockService.Get(id);

            return Ok(stock);
        }
    }
}
