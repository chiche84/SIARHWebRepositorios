using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Extensions.Logging;

using Microsoft.EntityFrameworkCore;

using Me.Siarh.Pof.Domain.Entities;
using Me.Siarh.Pof.Persistence.Filters;
using Me.Siarh.Common.Persistence;

namespace Me.Siarh.Pof.Persistence
{
    public class RefFuncionRepository : GenericRepository<RefFuncion, RefFuncionFilter>, IRefFuncionRepository
    {
        
        public RefFuncionRepository(PofDbContext context, ILogger logger) : base(context, logger )
        {            
        }

        public override async Task<bool> Create(RefFuncion entity)
        {
            try
            {
                entity.EstaActivo = true;
                await dbSet.AddAsync(entity);
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} Upsert function error", typeof(RefFuncionRepository));
                return false;
            }
        }

        public override async Task<bool> Update(RefFuncion entity)
        {
            try
            {
                var existingFuncion = await dbSet.Where(x => x.IdFuncion == entity.IdFuncion).FirstOrDefaultAsync();

                if (existingFuncion == null) return false;

                existingFuncion.FuncionDesc = entity.FuncionDesc;
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} Upsert function error", typeof(RefFuncionRepository));
                return false;
            }
        }

        public override async Task<bool> Delete(int id)
        {
            try
            {
                var existingFuncion = await dbSet.Where(x => x.IdFuncion == id).FirstOrDefaultAsync();

                if (existingFuncion == null) return false;

                existingFuncion.EstaActivo = false;
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} Delete function error", typeof(RefFuncionRepository));
                return false;
            }
        }
        
        public override async Task<IEnumerable<RefFuncion>> Filter(RefFuncionFilter filter)
        {
            var query = dbSet.AsQueryable();

            if (filter.Id != 0)
                query = query.Where(x => x.IdFuncion == filter.Id);

            if (filter.FuncionDesc != null)
                query = query.Where(x => x.FuncionDesc == filter.FuncionDesc);

            if (filter.FuncionDescContains != null)
                query = query.Where(x => x.FuncionDesc.Contains(filter.FuncionDesc));

            if (filter.EstaActivo != null)
                query = query.Where(x => x.EstaActivo == filter.EstaActivo);

            return await query.ToListAsync();
        }

    }
}

