using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SIARH.Aplication;
using SIARH.Persistence.Models;

namespace SIARH.Persistence
{
    public interface IRefEscalafonRepository : IGenericRepository<RefEscalafon>
    {
        Task<IEnumerable<RefEscalafon>> GetByGrupoNivel(int idGrupoNivel);
    }
}
