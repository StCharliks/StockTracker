namespace DolbojebInvest.Domain.Currencies
{
    public record ConversionRate
    {
        public CurrencyCode FromCurrency { get; init; }
        public CurrencyCode ToCurrency { get; init; }
        public decimal Rate { get; init; }
    }
}
