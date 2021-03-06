using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SIARH.POF.Persistence.Repositories;

namespace SIARH.POF.Persistence.UnitOfWork
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
        void Dispose();
    }
}
