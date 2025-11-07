namespace DolbojebInvest.Domain.Instruments
{
    public class Instrument
    {
        public long Id { get; init; }
        public string Isin { get; init; } = null!;
        public string Ticker { get; init; } = null!;
        public string Name { get; init; } = null!;
        public InstrumentType Type { get; init; }
    }
}
