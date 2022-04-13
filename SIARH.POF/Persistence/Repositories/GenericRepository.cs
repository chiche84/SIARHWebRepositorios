using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SIARH.POF.Persistence.Filters;

namespace SIARH.POF.Persistence.Repositories
{
    public abstract class GenericRepository<T, U> : IGenericRepository<T, U> where T : class where U : GenericFilter
    {
        protected DbContext _context;
        internal DbSet<T> dbSet;
        protected readonly ILogger _logger;


        public GenericRepository(DbContext context, ILogger logger)
        {
            this._context = context;
            this.dbSet = context.Set<T>();
            this._logger = logger;
        }


        public abstract Task<bool> Create(T entity);

        public abstract Task<bool> Update(T entity);

        public abstract Task<bool> Delete(int id);

        public abstract Task<IEnumerable<T>> Filter(U entity);

    }
}

