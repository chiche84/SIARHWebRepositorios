using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIARH.Persistence.Interfaces
{
    public abstract class GenericFilter
    {
        public virtual List<int> IncludeIds { get; set; }
        public virtual List<int> ExcludeIds { get; set; }

        public GenericFilter()
        {
            IncludeIds = new List<int>();   
            ExcludeIds = new List<int>();
        }
    }
}
