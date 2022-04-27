using Me.Siarh.Common.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Me.Siarh.Common.Application
{
    public interface IGenericService<T, U> where T : IDTO where U : IFilterDTO
    {
        //command
        Task<Result<T>> Create(T dtoEntityIn);
        Task<Result<T>> Update(T dtoEntityIn);
        Task<Result<T>> Delete(T dtoEntityIn);
        
        //query
        Task<Result<T>> GetById(int id);
        Task<Result<T>> GetByFilter(U dtofilter);


        //validation
        Task<Result<T>> CreatePostConditions(T dtoEntityIn);
        Task<Result<T>> CreatePreConditions(T dtoEntityIn);
        Task<Result<T>> UpdatePreConditions(T dtoEntityIn);
        Task<Result<T>> UpdatePostConditions(T dtoEntityIn);
        Task<Result<T>> DeletePreConditions(T dtoEntityIn);
        Task<Result<T>> DeletePostConditions(T dtoEntityIn);
    }
}
