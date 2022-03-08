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
using SIARH.Persistence.Interfaces;

namespace SIARH.Persistence
{
    public class RefAmbitoRepository : GenericRepository<RefAmbito, RefAmbitoFilter>, IRefAmbitoRepository
    {
        
        public RefAmbitoRepository(RRHH_V2Context context) : base(context )
        {            
        }

        public override async Task<IEnumerable<RefAmbito>> All()
        {
            try
            {
                return await dbSet.ToListAsync();
            }
            catch (Exception ex)
            {
                //_logger.LogError(ex, "{Repo} All function error", typeof(RefAmbitoRepository));
                return new List<RefAmbito>();
            }
        }
        public override async Task<bool> Upsert(RefAmbito entity)
        {
            try
            {
                var existingUser = await dbSet.Where(x => x.IdAmbito == entity.IdAmbito)
                                                    .FirstOrDefaultAsync();

                if (existingUser == null)
                    return await Add(entity);

                existingUser.AmbitoDesc = entity.AmbitoDesc;

                return true;
            }
            catch (Exception ex)
            {
                //_logger.LogError(ex, "{Repo} Upsert function error", typeof(RefAmbitoRepository));
                return false;
            }
        }

        public override async Task<bool> Delete(int id)
        {
            try
            {
                var exist = await dbSet.Where(x => x.IdAmbito == id)
                                        .FirstOrDefaultAsync();

                if (exist == null) return false;

                dbSet.Remove(exist);

                return true;
            }
            catch (Exception ex)
            {
                //_logger.LogError(ex, "{Repo} Delete function error", typeof(RefAmbitoRepository));
                return false;
            }
        }

        public Task<IEnumerable<RefAmbito>> GetByAmbito()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<RefAmbito>> Filter(RefAmbitoFilter filter)
        {
            var query = dbSet.AsQueryable();

            if (filter.IdAmbito != 0)
                query = query.Where(x => x.IdAmbito == filter.IdAmbito);

            if (filter.AmbitoDesc != null)
                query = query.Where(x => x.AmbitoDesc.Contains(filter.AmbitoDesc));

            if (filter.EstaActivo != null)
                query = query.Where(x => x.EstaActivo == filter.EstaActivo);

            return await query.ToListAsync();
        }

       
    }
}

