using DolbojebInvest.Domain.Currency;
using DolbojebInvest.Domain.Instruments;
using StockTracker.Domain.Stocks.Models;

namespace DolbojebInvest.Domain.InvestEvents
{
    public class InvestEvent
    {
        public long Id { get; init; }

        public DateTimeOffset EventDate { get; init; }

        public InvestEventType EventType { get; init; }

        public required Instrument Instrument { get; init; }

        public decimal Quantity { get; init; }

        public decimal Price { get; init; }

        public decimal TotalAmount { get; init; }

        public Currency Currency {  get; init; }

        public string? Comment { get; init; }
    }
}
