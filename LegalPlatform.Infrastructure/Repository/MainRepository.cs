using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using LegalPlatform.Infrastructure.Persistence.Context;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace LegalPlatform.Infrastructure.Repository
{
    public class MainRepository<TEntity> : IMainRepository<TEntity> where TEntity : class
    {
        private readonly LegalPlatformContext _context;
        private readonly IConfiguration _confguration;
        private readonly DbSet<TEntity> _entity;
        private readonly string _connection; 
        public MainRepository(LegalPlatformContext context,IConfiguration confg)
        {
            _context = context;
            this._confguration = confg;
            _entity = _context.Set<TEntity>();
            this._connection = _confguration.GetConnectionString("ConnectionString");   
        }

        public async ValueTask<string> CreateAsync(TEntity entity)
        {
            await _entity.AddAsync(entity);
            var addingResult = await _context.SaveChangesAsync();
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
            using (IDbConnection connection = new SqlConnection(_connection))
            {
                var Sql = $"SELECT * FROM {typeof(TEntity).Name} WHERE ID = @Id";
                return await connection.QuerySingleOrDefaultAsync<TEntity>(Sql, new { Id = id });
            }
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
