using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

using SIARH.Persistence.Filters;
using SIARH.Persistence.Models;

namespace SIARH.Persistence
{
    public class RefEscalafonRepository : GenericRepository<RefEscalafon, RefEscalafonFilter>, IRefEscalafonRepository
    {
        public RefEscalafonRepository(RRHH_V2Context context, ILogger logger) : base(context, logger)
        {
        }
        public override async Task<bool> Update(RefEscalafon entity)
        {
            try
            {
                var existingEscalafon = await dbSet.Where(x => x.IdEscalafon == entity.IdEscalafon).FirstOrDefaultAsync();

                if (existingEscalafon == null) return false;

                existingEscalafon.EscalafonDesc = entity.EscalafonDesc;
                existingEscalafon.Nomenclatura = entity.Nomenclatura;
                existingEscalafon.IdGrupoNivel = entity.IdGrupoNivel;   
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
                var existingEscalafon = await dbSet.Where(x => x.IdEscalafon == id).FirstOrDefaultAsync();

                if (existingEscalafon == null) return false;

                existingEscalafon.EstaActivo = false;
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} Delete function error", typeof(RefAmbitoRepository));
                return false;
            }
        }

        public override async Task<IEnumerable<RefEscalafon>> Filter(RefEscalafonFilter filter)
        {
            var query = dbSet.AsQueryable();

            if (filter.IdEscalafon != 0)
                query = query.Where(x => x.IdEscalafon == filter.IdEscalafon);

            if (filter.EscalafonDesc != null)
                query = query.Where(x => x.EscalafonDesc == filter.EscalafonDesc);

            if (filter.EscalafonDescContains != null)
                query = query.Where(x => x.EscalafonDesc.Contains(filter.EscalafonDesc));

            if (filter.Nomenclatura != null)
                query = query.Where(x => x.Nomenclatura == filter.Nomenclatura);

            if (filter.IdGrupoNivel != null)
                query = query.Where(x => x.IdGrupoNivel == filter.IdGrupoNivel);

            if (filter.EstaActivo != null)
                query = query.Where(x => x.EstaActivo == filter.EstaActivo);

            return await query.ToListAsync();
        }

    }
}
