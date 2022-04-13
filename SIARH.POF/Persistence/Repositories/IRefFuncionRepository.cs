using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIARH.POF.Persistence.Filters;
using SIARH.POF.Persistence.Models;
using SIARH.POF.Persistence.Repositories;

namespace SIARH.POF.Persistence.Repositories
{
    public interface IRefFuncionRepository : IGenericRepository<RefFuncion, RefFuncionFilter>
    {
      

    }
}
