namespace LegalPlatform.Infrastructure.Repository
{
    public interface IMainRepository <TEntity> where TEntity :class
    {
        ValueTask<string> CreateAsync(TEntity entity);
        ValueTask<string> UpdateAsync(TEntity entity , int id);
        ValueTask<string> DeleteAsync(int id);
        ValueTask<TEntity> GetAsync(int id);
        ValueTask<ICollection<TEntity>> GetAllAsync();
    }
}
