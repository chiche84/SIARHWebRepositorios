using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Extensions.Logging;
using SIARH.Persistence.Models;

namespace SIARH.Persistence.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly RRHH_V2Context _context;
        private readonly ILogger _logger;      

        private RefAmbitoRepository? _refAmbitoRepository;
        private RefEscalafonRepository? _refEscalafonRepository;
        private RefGrupoNivelRepository? _refGrupoNivelRepository;
        public IRefAmbitoRepository RefAmbitoRepository => _refAmbitoRepository = _refAmbitoRepository ?? new RefAmbitoRepository(_context, _logger);
        public IRefEscalafonRepository RefEscalafonRepository => _refEscalafonRepository = _refEscalafonRepository ?? new RefEscalafonRepository(_context, _logger);
        public IRefGrupoNivelRepository RefGrupoNivelRepository => _refGrupoNivelRepository = _refGrupoNivelRepository ?? new RefGrupoNivelRepository(_context, _logger);

        public UnitOfWork(RRHH_V2Context context, ILoggerFactory loggerFactory)

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
