namespace LegalPlatform.Infrastructure.Repository
{
    public interface IMainRepository <TEntity> where TEntity :class
    {
        ValueTask<string> CreateAsync(TEntity entity);
        ValueTask<string> UpdateAsync(TEntity entity , Guid id);
        ValueTask<string> DeleteAsync(Guid id);
        ValueTask<TEntity> GetAsync(Guid id);
        ValueTask<ICollection<TEntity>> GetAllAsync();
    }
}
