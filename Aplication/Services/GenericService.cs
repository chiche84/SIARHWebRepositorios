using SIARH.Aplication.Interfaces;
using SIARH.Aplication.Models;
using SIARH.Persistence.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SIARH.Aplication.Services
{
    public abstract class GenericService<T, U> where T : IDTO where U : GenericFilter, new()
    {
        //query

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
