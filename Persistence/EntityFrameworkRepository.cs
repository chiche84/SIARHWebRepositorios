using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

using SIARH.Aplication;
using SIARH.Persistence.Models;

namespace SIARH.Persistence
{
    
    public class EntityFrameworkRepository<T> : IGenericRepository<T> where T : class
    {
        private DbSet<T> table;
        private readonly RRHH_V2Context _context;
                 

        public EntityFrameworkRepository(RRHH_V2Context context)
        {       
            table = context.Set<T>();
            _context = context;
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await table.ToListAsync();
        }

        public async Task<T?> GetById(object id)
        {
            return await table.FindAsync(id);
        }

        public async Task Insert(T obj)
        {
            await table.AddAsync(obj);
        }

        public void Update(T obj)
        {
            table.Update(obj);
        }

        public async Task Delete(object id)
        {
            T existing = await table.FindAsync(id);
            if (existing != null) table.Remove(existing);
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
