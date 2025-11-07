using DolbojebInvest.Domain.Common;
using StockTracker.Domain.Stocks.Models;

namespace DolbojebInvest.Domain.Dividends.Models
{
    public record Dividend
    {
        public required Guid Id { get; init; }
        public required string Isin { get; init; }
        public required DateTimeOffset Date { get; init; }
        public required decimal Amount { get; init; }
        public required Currency Currency { get; init; }
        //public Document? Document { get; init; }
    }
}
