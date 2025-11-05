namespace DolbojebInvest.Domain.Base
{
    public interface IIdGenerator<TId> where TId : notnull, IEquatable<TId>
    {
        TId GenerateId();

        Task<TId> GenerateIdAsync();
    }
}
