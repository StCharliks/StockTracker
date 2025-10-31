namespace StockTracker.Domain.Stocks.Models
{
    public class Stock
    {
        public required string Isin { get; init; }

        public required string Ticker { get; init; }

        public required string CompanyName { get; init; }
    }
}
