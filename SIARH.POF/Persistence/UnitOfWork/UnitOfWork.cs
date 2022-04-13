using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using SIARH.POF.Persistence.Repositories;

namespace SIARH.POF.Persistence.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly SiarhPofDbContext _context;
        private readonly ILogger _logger;      

        private RefFuncionRepository? _refFuncionRepository;

        public IRefFuncionRepository RefFuncionRepository => _refFuncionRepository = _refFuncionRepository ?? new RefFuncionRepository(_context, _logger);

        public UnitOfWork(SiarhPofDbContext context, ILoggerFactory loggerFactory)
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
