using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Me.Siarh.Common.Application
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

        internal Result(IList<T> entities, Paged paged, bool succeeded, IEnumerable<string> errors)
        {
            Entities = entities;
            Paged = paged;
            Succeeded = succeeded;
            Errors = errors.ToArray();
        }

        //Prop
        public IList<T> Entities { get; set; }

        public bool Succeeded { get; set; }

        public string[] Errors { get; set; }

        public Paged Paged{ get; set; }

    //Meth
    public static Result<T> Success(T entity)
        {
            List<T> entities = new List<T>();
            Paged paged = new Paged();
            entities.Add(entity);

            return new Result<T>(entities, paged,  true, Array.Empty<string>());
        }

        public static Result<T> Success(IList<T> entities)
        {
            Paged paged = new Paged();
            return new Result<T>(entities, paged, true, Array.Empty<string>());
        }

        public static Result<T> Success(IList<T> entities, Paged paged)
        {
            return new Result<T>(entities, paged, true, Array.Empty<string>());
        }

        public static Result<T> Failure(T entity, IEnumerable<string> errors)
        {
            List<T> entities = new List<T>();
            Paged paged = new Paged();
            entities.Add(entity);
            return new Result<T>(entities, paged, false, errors);
        }

        public static Result<T> Failure(IList<T> entities, IEnumerable<string> errors)
        {
            Paged paged = new Paged();
            return new Result<T>(entities, paged, false, errors);
        }
    }

}
