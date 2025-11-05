namespace StockTracker.Domain.Stocks.Models
{
    public class Position
    {
        public long Id { get; init; }

        public int Volume { get; init; }

        public DateTimeOffset OpenDate { get; init; }

        public decimal Price { get; init; }

        public decimal PriceTotal => Price * Volume;

        public required Stock Stock { get; init; }
    }
}
