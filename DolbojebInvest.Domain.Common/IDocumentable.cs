using DolbojebInvest.Domain.Common;

namespace DolbojebInvest.Domain.Base
{
    public interface IDocumentable
    {
        public Document? Document { get; set; }
    }
}
