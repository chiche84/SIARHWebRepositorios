using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Me.Siarh.Common.Persistence
{
    public interface IGenericRepository<T, U> where T : class   where U : GenericFilter
    {
        Task<bool> Create(T entity);
        Task<bool> Update(T entity);
        Task<bool> Delete(int id);
        IQueryable<T> Filter(U filter);
        Task<IEnumerable<T>> FilterPaginated(U filter);

        int TotalItems();

    }
}
