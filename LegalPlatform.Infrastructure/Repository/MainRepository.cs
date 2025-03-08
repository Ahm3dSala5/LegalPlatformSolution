using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LegalPlatform.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace LegalPlatform.Infrastructure.Repository
{
    public class MainRepository<TEntity> : IMainRepository<TEntity> where TEntity : class
    {
        private readonly LegalPlatformContext _context;
        private readonly DbSet<TEntity> _entity;
        public MainRepository(LegalPlatformContext context)
        {
            _context = context;
            _entity = _context.Set<TEntity>();
        }

        public async ValueTask<string> CreateAsync(TEntity entity)
        {
            await _entity.AddAsync(entity);
            var addingResult = await  _context.SaveChangesAsync();
            return addingResult > 0 ? "Successfully" : "Invalid";
        }

        public async ValueTask<string> DeleteAsync(Guid id)
        {
            var entity = await _entity.FindAsync(id);
            if (entity == null)
                return "NotFound";

            _entity.Remove(entity);
            var removeResult = await _context.SaveChangesAsync();
            return removeResult > 0 ? "Successfully" : "Invalid";
        }

        public async ValueTask<ICollection<TEntity>> GetAllAsync()
        {
            return await _entity.ToListAsync();
        }

        public async ValueTask<TEntity> GetAsync(Guid id)
        {
            return await _entity.FindAsync(id);
        }

        public async ValueTask<string> UpdateAsync(TEntity entity, Guid id)
        {
            var oldEntity = await _entity.FindAsync(id);
            if (entity == null)
                return "NotFound";

            _entity.Entry(oldEntity).CurrentValues.SetValues(entity);
            var updateResult = await _context.SaveChangesAsync();
            return updateResult > 0 ? "Successfully" : "Invalid";
        }
    }
}
