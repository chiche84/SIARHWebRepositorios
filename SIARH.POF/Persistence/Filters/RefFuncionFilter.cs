
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIARH.POF.Persistence.Filters
{
    public class RefFuncionFilter : GenericFilter
    {
        public string FuncionDesc { get; set; }
        public string FuncionDescContains { get; set; }
    }
}
