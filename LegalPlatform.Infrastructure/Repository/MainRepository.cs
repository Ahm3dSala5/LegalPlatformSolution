using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LegalPlatform.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace LegalPlatform.Infrastructure.Repository
{
    internal class MainRepository<TEntity> : IMainRepository<TEntity> where TEntity : class
    {
        private readonly LegalPlatformContext _context;
        private readonly DbSet<TEntity> _entity;
        public MainRepository(LegalPlatformContext context)
        {
            _context = context;
            _entity = _context.Set<TEntity>();
        }

        public ValueTask<string> CreateAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public ValueTask<string> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public ValueTask<ICollection<TEntity>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<TEntity> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public ValueTask<string> UpdateAsync(TEntity entity, int id)
        {
            throw new NotImplementedException();
        }
    }
}
