namespace DolbojebInvest.Domain.Currencies
{
    public class Currency
    {
        public long Id { get; init; }
        public CurrencyCode Code { get; init; }
        public string Name { get; init; } = null!;
    }
}
