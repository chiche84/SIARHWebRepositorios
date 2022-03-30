using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Extensions.Logging;

using Microsoft.EntityFrameworkCore;
using SIARH.Persistence.Models;
using SIARH.Persistence.Filters;

namespace SIARH.Persistence
{
    public class RefAmbitoRepository : GenericRepository<RefAmbito, RefAmbitoFilter>, IRefAmbitoRepository
    {
        
        public RefAmbitoRepository(RRHH_V2Context context, ILogger logger) : base(context, logger )
        {            
        }

        public override async Task<bool> Create(RefAmbito entity)
        {
            try
            {
                entity.EstaActivo = true;
                await dbSet.AddAsync(entity);
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} Upsert function error", typeof(RefAmbitoRepository));
                return false;
            }
        }

        public override async Task<bool> Update(RefAmbito entity)
        {
            try
            {
                var existingAmbito = await dbSet.Where(x => x.IdAmbito == entity.IdAmbito).FirstOrDefaultAsync();

                if (existingAmbito == null) return false;

                existingAmbito.AmbitoDesc = entity.AmbitoDesc;
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} Upsert function error", typeof(RefAmbitoRepository));
                return false;
            }
        }

        public override async Task<bool> Delete(int id)
        {
            try
            {
                var existingAmbito = await dbSet.Where(x => x.IdAmbito == id).FirstOrDefaultAsync();

                if (existingAmbito == null) return false;

                existingAmbito.EstaActivo = false;
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} Delete function error", typeof(RefAmbitoRepository));
                return false;
            }
        }
        
        public override async Task<IEnumerable<RefAmbito>> Filter(RefAmbitoFilter filter)
        {
            var query = dbSet.AsQueryable();

            if (filter.IdAmbito != 0)
                query = query.Where(x => x.IdAmbito == filter.IdAmbito);

            if (filter.AmbitoDesc != null)
                query = query.Where(x => x.AmbitoDesc == filter.AmbitoDesc);

            if (filter.AmbitoDescContains != null)
                query = query.Where(x => x.AmbitoDesc.Contains(filter.AmbitoDesc));

            if (filter.EstaActivo != null)
                query = query.Where(x => x.EstaActivo == filter.EstaActivo);

            return await query.ToListAsync();
        }

    }
}

