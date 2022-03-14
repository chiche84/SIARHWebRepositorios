using SIARH.Aplication.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIARH.Aplication.Models
{
    public class Result<T> where T : IDTO
    {
        //Ctor
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
        public static Result<T> Success(IList<T> entities)
        {
            return new Result<T>(entities, true, Array.Empty<string>());
        }

        public static Result<T> Failure(IList<T> entities, IEnumerable<string> errors)
        {
            return new Result<T>(entities, false, errors);
        }
      
    }

}
