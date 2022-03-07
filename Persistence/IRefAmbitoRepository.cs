using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using SIARH.Persistence.Models;

namespace SIARH.Persistence
{
    public interface IRefAmbitoRepository : IGenericRepository<RefAmbito>
    {
        Task<IEnumerable<RefAmbito>> GetByAmbito();
    }
}
