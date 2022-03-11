using SIARH.Aplication.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIARH.Aplication.Models
{
    public class Result<T> where T : IEnumerable
    {
        internal Result(T entity, bool succeeded, IEnumerable<string> errors)
        {
            Entity = entity;
            Succeeded = succeeded;
            Errors = errors.ToArray();
        }

        public T Entity { get; set; }

        public bool Succeeded { get; set; }

        public string[] Errors { get; set; }

        public static Result<T> Success(T entity)
        {
            return new Result<T>(entity, true, Array.Empty<string>());
        }

        public static Result<T> Failure(T entity, IEnumerable<string> errors)
        {
            return new Result<T>(entity, false, errors);
        }
      
    }

}
