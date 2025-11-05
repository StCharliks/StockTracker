namespace StockTracker.Domain.Base.DataAccess
{
    public interface IReadOnlyRepository<TEntity, TKey> where TEntity : class
    {
        Task<IReadOnlyList<TEntity>> GetAllAsync();
        Task<TEntity> GetById(TKey id);
    }
}
