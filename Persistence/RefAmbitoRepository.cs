using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

using SIARH.Aplication;
using SIARH.Persistence.Models;

namespace SIARH.Persistence
{
    public class RefAmbitoRepository : IGenericRepository<RefAmbito>
    {
        private readonly RRHH_V2Context _context;
        private DbSet<RefAmbito> tablaRefAmbito;

        public RefAmbitoRepository(RRHH_V2Context context)
        {
            this._context = context;
            tablaRefAmbito = context.Set<RefAmbito>();

        }
        public async Task <IEnumerable<RefAmbito>> FilterBy(string PambitoDesc)
        {
            return await tablaRefAmbito.Where(x => x.AmbitoDesc.Contains(PambitoDesc)).ToListAsync();
        }
        public Task Delete(object id)
        {
            throw new NotImplementedException();
        }
        public async Task<IEnumerable<RefAmbito>> GetAll()
        {
            return await tablaRefAmbito.Where(x=> x.EstaActivo == true).ToListAsync();
        }

        public Task<RefAmbito?> GetById(object id)
        {
            throw new NotImplementedException();
        }

        public Task Insert(RefAmbito obj)
        {
            throw new NotImplementedException();
        }

        public Task Save()
        {
            throw new NotImplementedException();
        }

        public void Update(RefAmbito obj)
        {
            throw new NotImplementedException();
        }
    }
}
