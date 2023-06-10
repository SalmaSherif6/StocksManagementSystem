namespace StocksManagementSystem.Domain.DTO
{
    public class OrderDTO
    {
        /// <summary>
        /// The stock identifier.
        /// </summary>
        public int StockID { get; set; }

        /// <summary>
        /// The order price.
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// The order quantity.
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// The person name.
        /// </summary>
        public string PersonName { get; set; }
    }
}
