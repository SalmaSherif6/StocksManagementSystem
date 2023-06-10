using Microsoft.AspNetCore.Mvc;
using StocksManagementSystem.API.Interfaces;
using StocksManagementSystem.Domain.Entities;
using StocksManagementSystem.Services.Interfaces;

namespace StocksManagementSystem.API.Controllers
{
    [Route("api/stocks")]
    [ApiController]
    public class StockController : ControllerBase
    {
        private IStockService _stockService;
        private ISignalRService _signalRService;

        public StockController(IStockService stockService, ISignalRService signalRService)
        {
            _stockService = stockService;
            _signalRService = signalRService;
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

        /// <summary>
        /// Handles an HTTP GET request to shuffle the prices of stocks and send a notification to clients using SignalR.
        /// </summary>
        /// <returns></returns>
        [HttpGet("shuffleStockPrices")]
        public async Task<ActionResult> ShuffleStockPrices()
        {
            await _stockService.ShufflePrices();

            await _signalRService.SendStockPricesUpdateNotification();

            return Ok();
        }

    }
}
