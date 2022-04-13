using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

using SIARH.Persistence.Models;

namespace SIARH.Persistence.UnitOfWork
{
    public interface IUnitOfWork
    {
        IRefAmbitoRepository RefAmbitoRepository { get; }
        IRefEscalafonRepository RefEscalafonRepository { get; }
        IRefGrupoNivelRepository RefGrupoNivelRepository { get; }

        Task CompleteAsync();
        void Dispose();
    }
}
