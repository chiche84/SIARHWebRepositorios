using SIARH.Persistence.Interfaces;
using SIARH.Persistence.Models;
using SIARH.Persistence.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIARH.Persistence.Filters
{
    public class RefAmbitoFilter : GenericFilter
    {
        public int IdAmbito { get; set; }
        public string AmbitoDesc { get; set; }
        public bool? EstaActivo { get; set; }
        public string AmbitoDescContains { get; set; }
    }
}
