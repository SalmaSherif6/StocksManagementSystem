namespace StocksManagementSystem.Domain.Entities
{
    public class Stock
    {
        /// <summary>
        /// The stock identifier.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The stock name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The stock price.
        /// </summary>
        public decimal Price { get; set; }
    }
}
