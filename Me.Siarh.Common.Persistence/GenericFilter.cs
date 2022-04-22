using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Me.Siarh.Common.Persistence
{
    public abstract class GenericFilter
    {
        public virtual List<int> IncludeIds { get; set; }
        public virtual List<int> ExcludeIds { get; set; }

        public int Id { get; set; }
        public bool? EstaActivo { get; set; }

        public int PageNumber { get; set; }
        public int PageSize { get; set; } 


        public GenericFilter()
        {
            IncludeIds = new List<int>();
            ExcludeIds = new List<int>();

            PageNumber = 1;
            PageSize = 10;
        }
    }
}
