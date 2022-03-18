using SIARH.Aplication.Models;
using SIARH.Persistence.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SIARH.Aplication.Interfaces
{
    public interface IService<T, U> where T : IDTO where U : IFilter
    {
        Task<T> GetById(int id);
        Task<Result<T>> Add(T entity);
        Task<Result<T>> Delete(int id);
        Task<Result<T>> Upsert(T entity);
        Task<Result<T>> Find(Expression<Func<T, bool>> predicate);
        Task<Result<T>> Filter(U entity);
    }
}
