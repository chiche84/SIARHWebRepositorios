
using Me.Siarh.Common.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Me.Siarh.Common.Application
{
    public abstract class GenericService<T, U> : IGenericService<T, U>  where T : IDTO where U : IFilterDTO, new()
    {
        //command
        public abstract Task<Result<T>> Create(T entity);
        public abstract Task<Result<T>> Update(T entity);
        public abstract Task<Result<T>> Delete(T entity);

        //query
        public abstract Task<Result<T>> GetById(int id);
        public abstract Task<Result<T>> GetByFilter(U filter);

        //validation
        public virtual async Task<Result<T>> CreatePostConditions(T entity)
        {
            List<T> entities = new List<T>();
            entities.Add(entity);   
            return Result<T>.Success(entities);
        }
        public virtual async Task<Result<T>> CreatePreConditions(T entity)
        {
            List<T> entities = new List<T>();
            entities.Add(entity);
            return Result<T>.Success(entities);
        }
        public virtual async Task<Result<T>> UpdatePreConditions(T entity)
        {
            List<T> entities = new List<T>();
            entities.Add(entity);
            return Result<T>.Success(entities);
        }
        public virtual async Task<Result<T>> UpdatePostConditions(T entity)
        {
            List<T> entities = new List<T>();
            entities.Add(entity);
            return Result<T>.Success(entities);
        }
        public virtual async Task<Result<T>> DeletePreConditions(T entity)
        {
            List<T> entities = new List<T>();
            entities.Add(entity);
            return Result<T>.Success(entities);
        }
        public virtual async Task<Result<T>> DeletePostConditions(T entity)
        {
            List<T> entities = new List<T>();
            entities.Add(entity);
            return Result<T>.Success(entities);
        }




       
    }
}
