using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore;
using SIARH.Aplication;
using Microsoft.Extensions.Logging;
using SIARH.Persistence.Models;

namespace SIARH.Persistence.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly RRHH_V2Context _context;
        //private readonly ILogger _logger;
        public IRefAmbitoRepository RefAmbito { get; private set; }

        public UnitOfWork(RRHH_V2Context context)//, ILoggerFactory loggerFactory)
        {
            _context = context;
            //_logger = loggerFactory.CreateLogger("logs");

            RefAmbito = new RefAmbitoRepository(context);
        }

        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
