using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Me.Siarh.Common.Persistence
{
    public abstract class GenericRepository<T, U> : IGenericRepository<T, U> where T : class where U : GenericFilter
    {
        protected DbContext _context;
        protected DbSet<T> dbSet;
        protected readonly ILogger _logger;
        private int totalItems;

        public GenericRepository(DbContext context, ILogger logger)
        {
            this._context = context;
            this.dbSet = context.Set<T>();
            this._logger = logger;
            this.totalItems = dbSet.Count();
        }

        public virtual async Task<bool> Create(T entity)
        {
            await dbSet.AddAsync(entity);
            return true;
        }

        public abstract Task<bool> Update(T entity);

        public abstract Task<bool> Delete(int id);

        public abstract IQueryable<T> Filter(U filter);

        public async Task<IEnumerable<T>> FilterPaginated(U filter)
        {
            totalItems = await Filter(filter).CountAsync();

            return await Filter(filter).Skip((filter.PageNumber - 1) * filter.PageSize).Take(filter.PageSize).ToListAsync();
        }

        public int TotalItems()
        {
            return totalItems;
        }



        //utils
        //public bool IntegrityCheck(T entity, string key, int value)
        //{
        //    try
        //    {
        //        ObjectParameter errorRetornado = new ObjectParameter("error", typeof(String));
        //        msp.spCheckDELETE(entity.GetType().Name, value, errorRetornado);
        //        this.error = errorRetornado.Value.ToString();
        //        return (error == "True") ? false : true;
        //    }
        //    catch (Exception ex)
        //    {
        //        this.error = "Error" + ex.Message;
        //        return false;
        //    }
        //}

    }
}

