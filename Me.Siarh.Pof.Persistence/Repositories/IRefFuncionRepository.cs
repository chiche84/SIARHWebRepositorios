using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Me.Siarh.Common.Persistence;
using Me.Siarh.Pof.Domain.Entities;
using Me.Siarh.Pof.Persistence.Filters;

namespace Me.Siarh.Pof.Persistence
{
    public interface IRefFuncionRepository : IGenericRepository<RefFuncion, RefFuncionFilter>
    {
      

    }
}
