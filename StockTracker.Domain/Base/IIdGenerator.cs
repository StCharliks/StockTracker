namespace DolbojebInvest.Domain.Base
{
    public interface IIdGenerator<TId> where TId : notnull, IEquatable<TId>
    {
        Task<TId> GenerateIdAsync();
    }
}
