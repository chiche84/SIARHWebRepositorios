using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

using SIARH.Aplication;
using SIARH.Persistence.Models;

namespace SIARH.Persistence
{
    public interface IRefAmbitoRepository : IGenericRepository<RefAmbito>
    {
        Task<IEnumerable<RefAmbito>> GetByAmbito();
    }
}
