using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Me.Siarh.Pof.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Me.Siarh.Common.Persistence
{
    public abstract class GenericRepository<T, U> : IGenericRepository<T, U> where T : GenericEntity, new() where U : GenericFilter
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
        
        //command
        public virtual async Task<bool> Create(T entity)
        {
            try
            {
                entity.EstaActivo = true;
                await dbSet.AddAsync(entity);
                return true;
            }
            catch (Exception ex)
            {
                //_logger.LogError(ex, "{Repo} Upsert function error", typeof(RefFuncionRepository));
                _logger.LogError(ex, "{Repo} Upsert function error", "");
                return false;
            }
        }

        public virtual async Task<bool> Update(T entity)
        {
            try
            {
                T existEntity = await dbSet.Where(x => x.Id == entity.Id).FirstOrDefaultAsync();

                if (existEntity == null)
                    return false;

                Map(entity, existEntity);

                return true;
            }
            catch (Exception ex)
            {
                //_logger.LogError(ex, "{Repo} Upsert function error", typeof(RefFuncionRepository));
                _logger.LogError(ex, "{Repo} Upsert function error", "");
                return false;
            }
        }

        public virtual async Task<bool> Delete(T entity)
        {
            try
            {
                T existEntity = await dbSet.Where(x => x.Id == entity.Id).FirstOrDefaultAsync();

                if (existEntity == null) return false;

                existEntity.EstaActivo = false;
                return true;
            }
            catch (Exception ex)
            {
                //_logger.LogError(ex, "{Repo} Delete function error", typeof(RefFuncionRepository));
                _logger.LogError(ex, "{Repo} Delete function error", "");
                return false;
            }
        }

        //query
        public abstract IQueryable<T> Filter(U filter);

        public async Task<IEnumerable<T>> FilterPaginated(U filter)
        {
            totalItems = await Filter(filter).CountAsync();

            return await Filter(filter).Skip((filter.PageNumber - 1) * filter.PageSize).Take(filter.PageSize).ToListAsync();
        }

        private void Map(T entityFrom, T entityTo)
        {
            var propInfo = entityFrom.GetType().GetProperties();
            foreach (var item in propInfo)
            {
                entityTo.GetType().GetProperty(item.Name).SetValue(entityTo, item.GetValue(entityFrom, null), null);
            }
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

