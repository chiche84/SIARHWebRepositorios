using SIARH.Aplication.Interfaces;
using SIARH.Aplication.Models;
using SIARH.Persistence.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SIARH.Aplication.Services
{
    public abstract class GenericService<T, U> where T : IDTO where U : IFilter, new()
    {
        //command
        public virtual async Task<Result<T>> Create(T entity)
        {
            throw new NotImplementedException();
        }

        public virtual async Task<Result<T>> Update(T entity)
        {
            throw new NotImplementedException();
        }

        public virtual async Task<Result<T>> Delete(int id)
        {
            throw new NotImplementedException();
        }


        //query
        protected virtual async Task<List<T>> Filter(U entity)
        {
            throw new NotImplementedException();
        }

        public virtual async Task<List<T>> GetAll()
        {
            return await Filter(new U() {});
        }
        public virtual async Task<Result<T>> GetById(int id)
        {
            throw new NotImplementedException();
        }


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
