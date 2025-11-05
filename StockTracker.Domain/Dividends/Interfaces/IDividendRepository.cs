using DolbojebInvest.Domain.Dividends.Models;

namespace DolbojebInvest.Domain.Dividends.Interfaces
{
    public interface IDividendRepository
    {
        Task<IReadOnlyCollection<Dividend>> GetAllAsync();
        Task AddAsync(Dividend dividend);
    }
}
