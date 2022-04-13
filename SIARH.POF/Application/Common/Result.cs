using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIARH.POF.Application.Common
{
    public class Result<T> where T : IDTO
    {
        //Ctor
        internal Result()
        {
            Entities = new List<T>();
            Errors = new string[] { };
        }

        internal Result(bool succeeded, IEnumerable<string> errors)
        {
            Entities = new List<T>();
            Succeeded = succeeded;
            Errors = errors.ToArray();
        }

        internal Result(IList<T> entities, bool succeeded, IEnumerable<string> errors)
        {
            Entities = entities;
            Succeeded = succeeded;
            Errors = errors.ToArray();
        }

        //Prop
        public IList<T> Entities { get; set; }

        public bool Succeeded { get; set; }

        public string[] Errors { get; set; }

        //Meth
        public static Result<T> Success(T entity)
        {
            List<T> entities = new List<T>();
            entities.Add(entity);
            return new Result<T>(entities, true, Array.Empty<string>());
        }

        public static Result<T> Success(IList<T> entities)
        {
            return new Result<T>(entities, true, Array.Empty<string>());
        }

        public static Result<T> Failure(T entity, IEnumerable<string> errors)
        {
            List<T> entities = new List<T>();
            entities.Add(entity);
            return new Result<T>(entities, false, errors);
        }

        public static Result<T> Failure(IList<T> entities, IEnumerable<string> errors)
        {
            return new Result<T>(entities, false, errors);
        }
    }

}
