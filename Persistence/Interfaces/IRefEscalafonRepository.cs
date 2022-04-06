using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIARH.Persistence.Filters;
using SIARH.Persistence.Models;

namespace SIARH.Persistence
{
    public interface IRefEscalafonRepository : IGenericRepository<RefEscalafon, RefEscalafonFilter>
    {
    }
}
