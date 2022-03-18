using SIARH.Aplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIARH.Aplication.Interfaces
{
    internal interface IPreConditions<T, U> where T : class where U : IDTO
    {
        Task<Result<U>> IsValid(T entity);



    }
}
