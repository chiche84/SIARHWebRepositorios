using SIARH.POF.Persistence.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SIARH.POF.Persistence.Repositories
{
    public interface IGenericRepository<T, U> where T : class   where U : GenericFilter
    {
        Task<bool> Create(T entity);
        Task<bool> Update(T entity);
        Task<bool> Delete(int id);
        Task<IEnumerable<T>> Filter(U filter);

    }
}
