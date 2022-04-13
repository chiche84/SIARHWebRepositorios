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
    public class RefGrupoNivelRepository : GenericRepository<RefGrupoNivel, RefGrupoNivelFilter>, IRefGrupoNivelRepository
    {
        
        public RefGrupoNivelRepository(RRHH_V2Context context, ILogger logger) : base(context, logger )
        {            
        }

        public override async Task<bool> Create(RefGrupoNivel entity)
        {
            try
            {
                entity.EstaActivo = true;
                await dbSet.AddAsync(entity);
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} Upsert function error", typeof(RefGrupoNivelRepository));
                return false;
            }
        }

        public override async Task<bool> Update(RefGrupoNivel entity)
        {
            try
            {
                var existingGrupoNivel = await dbSet.Where(x => x.IdGrupoNivel == entity.IdGrupoNivel).FirstOrDefaultAsync();

                if (existingGrupoNivel == null) return false;

                existingGrupoNivel.GrupoDesc = entity.GrupoDesc;
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} Upsert function error", typeof(RefGrupoNivelRepository));
                return false;
            }
        }

        public override async Task<bool> Delete(int id)
        {
            try
            {
                var existingAmbito = await dbSet.Where(x => x.IdGrupoNivel == id).FirstOrDefaultAsync();

                if (existingAmbito == null) return false;

                existingAmbito.EstaActivo = false;
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} Delete function error", typeof(RefGrupoNivelRepository));
                return false;
            }
        }
        
        public override async Task<IEnumerable<RefGrupoNivel>> Filter(RefGrupoNivelFilter filter)
        {
            var query = dbSet.AsQueryable();

            if (filter.IdGrupoNivel != 0)
                query = query.Where(x => x.IdGrupoNivel == filter.IdGrupoNivel);

            if (filter.GrupoDesc != null)
                query = query.Where(x => x.GrupoDesc == filter.GrupoDesc);

            if (filter.GrupoDesc != null)
                query = query.Where(x => x.GrupoDesc.Contains(filter.GrupoDesc));

            if (filter.EstaActivo != null)
                query = query.Where(x => x.EstaActivo == filter.EstaActivo);

            return await query.ToListAsync();
        }

    
    }
}

