using StockTracker.Domain.Stocks.Models;

namespace DolbojebInvest.API.Dividends.Requests
{
    public class AddDividendRequest
    {
        public required string Isin { get; init; }
        public required DateOnly Date { get; init; }
        public required decimal Amount { get; init; }
        public required Currency Currency { get; init; }
        public IFormFile? Document { get; init; }
    }
}
