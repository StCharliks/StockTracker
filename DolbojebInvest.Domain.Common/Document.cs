namespace DolbojebInvest.Domain.Common
{
    public class Document
    {
        public required string FileName { get; init; }

        public required Stream DocumentContent { get; init; }
    }
}
