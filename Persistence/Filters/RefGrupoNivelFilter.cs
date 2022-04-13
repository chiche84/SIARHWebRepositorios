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
    public class RefGrupoNivelFilter : GenericFilter
    {
        public int IdGrupoNivel { get; set; }
        public string GrupoDesc { get; set; }
        public bool? EstaActivo { get; set; }
        public string GrupoDescContains { get; set; }
    }
}
