using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Me.Siarh.Common.Persistence;
using Microsoft.Extensions.Logging;


namespace Me.Siarh.Pof.Persistence.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly PofDbContext _context;
        private readonly ILogger _logger;      

        private RefFuncionRepository? _refFuncionRepository;

        public IRefFuncionRepository RefFuncionRepository => _refFuncionRepository = _refFuncionRepository ?? new RefFuncionRepository(_context, _logger);

        public UnitOfWork(PofDbContext context, ILoggerFactory loggerFactory)
        {
            _context = context;
            _logger = loggerFactory.CreateLogger("logs");         
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
