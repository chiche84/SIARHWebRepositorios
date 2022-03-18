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
    public class GenericService<T, U> : IService<T, U> where T : IDTO where U : IFilter
    {
        public virtual async Task<Result<T>> Add(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<Result<T>> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public virtual async Task<Result<T>> Filter(U entity)
        {
            throw new NotImplementedException();
        }

        public Task<Result<T>> Find(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Result<T>> Upsert(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
