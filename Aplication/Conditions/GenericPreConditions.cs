using SIARH.Aplication.Interfaces;
using SIARH.Aplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIARH.Aplication.Conditions
{
    internal class GenericPreConditions<T, U> : IPreConditions<T, U> where T : class where U : IDTO
    {
        public virtual async Task<Result<U>> IsValid(T entity)
        {
            return Result<U>.Success();
        }
    }
}
