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
    public class RefEscalafonRepository : GenericRepository<RefEscalafon, RefAmbitoFilter>, IRefEscalafonRepository
    {
        public RefEscalafonRepository(RRHH_V2Context context, ILogger logger) : base(context, logger)
        {
        }
        public override async Task<bool> Upsert(RefEscalafon entity)
        {
            try
            {
                var existingEscalafon = await dbSet.Where(x => x.IdEscalafon == entity.IdEscalafon)
                                                    .FirstOrDefaultAsync();

                if (existingEscalafon == null)
                    return await Add(entity);

                existingEscalafon.EscalafonDesc = entity.EscalafonDesc;

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public Task<IEnumerable<RefEscalafon>> GetByGrupoNivel(int idGrupoNivel)
        {
            throw new NotImplementedException();
        }
    }
}
