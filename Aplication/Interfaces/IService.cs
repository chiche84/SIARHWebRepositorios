using SIARH.Aplication.Models;
using SIARH.Persistence.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIARH.Aplication.Interfaces
{
    internal interface IService<T, U> where T : IDTO where U : GenericFilter
    {
        //command
        Task<Result<T>> Create(T entity);
        Task<Result<T>> Update(T entity);
        Task<Result<T>> Delete(T entity);
        
        //query
        Task<Result<T>> Get();
        Task<Result<T>> GetById(int id);
    }
}
