using StockTracker.Domain.Base.DataAccess;
using StockTracker.Domain.Stocks.Models;

namespace StockTracker.Domain.Stocks.Interfaces
{
    public interface IStockRepository : IReadOnlyRepository<Stock, string>
    {
    }
}
