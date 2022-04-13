
using Me.Siarh.Common.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Me.Siarh.Common.Application
{
    public abstract class GenericService<T, U> : IGenericService<T, U>  where T : IDTO where U : GenericFilter, new()
    {
        //command
        public abstract Task<Result<T>> Create(T entity);
        public abstract Task<Result<T>> Update(T entity);
        public abstract Task<Result<T>> Delete(T entity);

        //query
        public abstract Task<Result<T>> Get();
        public abstract Task<Result<T>> GetById(int id);

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

      
       

        //utils
        //public bool IntegrityCheck(T entity, string key, int value)
        //{
        //    try
        //    {
        //        ObjectParameter errorRetornado = new ObjectParameter("error", typeof(String));
        //        msp.spCheckDELETE(entity.GetType().Name, pObject.idCalendario, errorRetornado);
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
