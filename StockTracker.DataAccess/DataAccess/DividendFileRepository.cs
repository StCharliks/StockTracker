using DolbojebInvest.Domain.Dividends.Interfaces;
using DolbojebInvest.Domain.Dividends.Models;

namespace DolbojebInvest.Infrastructure.DataAccess
{
    public class DividendFileRepository : IDividendRepository
    {
        private const string FilePath = "dividends.json";
        private readonly IList<Dividend> _dividends;

        public DividendFileRepository()
        {
            // Load dividends from file or initialize an empty list
            _dividends = new List<Dividend>();

            if (File.Exists(FilePath))
            {
                var json = File.ReadAllText(FilePath);
                var dividends = System.Text.Json.JsonSerializer.Deserialize<List<Dividend>>(json);
                if (dividends != null)
                {
                    _dividends = dividends;
                }
            }
        }

        public async Task AddAsync(Dividend dividend)
        {
            _dividends.Add(dividend);

            await SaveToFileAsync();
        }

        public Task<IReadOnlyCollection<Dividend>> GetAllAsync()
        {
            return Task.FromResult((IReadOnlyCollection<Dividend>)_dividends);
        }

        private async Task SaveToFileAsync()
        {
            using (var fs = new FileStream(FilePath, FileMode.Truncate, FileAccess.Write))
            {
                await fs.WriteAsync(System.Text.Json.JsonSerializer.SerializeToUtf8Bytes(_dividends));
            }
        }
    }
}
