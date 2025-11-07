using DolbojebInvest.Domain.Common;
using DolbojebInvest.Domain.Dividends.Interfaces;
using DolbojebInvest.Domain.Dividends.Models;
using StockTracker.Domain.Stocks.Models;

namespace DolbojebInvest.Application.Dividends
{
    public class DividendService : IDividendService
    {
        public async Task AddDividendAsync(string isin, DateTime date, decimal amount, Currency currencyCode)
        {
            var dividend = new Dividend
            {
                Amount = amount,
                Currency = currencyCode,
                Date = date,
                Isin = isin
            };


        }
    }
}
