using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

namespace SIARH.Persistence.UnitOfWork
{
    public interface IUnitOfWork
    {
        IRefAmbitoRepository RefAmbito { get; }
        Task CompleteAsync();
        void Dispose();
    }
}
