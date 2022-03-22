using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SIARH.Persistence.Interfaces;
using SIARH.Persistence.Models;

namespace SIARH.Persistence
{
    public class GenericRepository<T, U> : IGenericRepository<T, U> where T : class where U : IFilter
    {
        protected RRHH_V2Context _context;
        internal DbSet<T> dbSet;
        protected readonly ILogger _logger;


        public GenericRepository(RRHH_V2Context context, ILogger logger)
        {
            this._context = context;
            this.dbSet = context.Set<T>();
            this._logger = logger;
        }

    

        public virtual async Task<bool> Create(T entity)
        {
            await dbSet.AddAsync(entity);
            return true;
        }

        public virtual async Task<bool> Update(T entity)
        {
            throw new NotImplementedException();
        }

        public virtual async Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }
        

        public virtual async Task<IEnumerable<T>> Filter(U entity)
        {
            throw new NotImplementedException();
        }

        //public virtual async Task<IEnumerable<T>> Find(Expression<Func<T, bool>> predicate)
        //{
        //    return await dbSet.Where(predicate).ToListAsync();
        //}
  

        //public virtual Task<IEnumerable<T>> All()
        //{
        //    throw new NotImplementedException();
        //}

        //public virtual async Task<T> GetById(int id)
        //{
        //    return await dbSet.FindAsync(id);
        //}
    }
}

