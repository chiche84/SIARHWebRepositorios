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
    public class RefEscalafonFilter : GenericFilter
    {
        public int IdEscalafon { get; set; }
        public string EscalafonDesc { get; set; } = null!;
        public string? Nomenclatura { get; set; }
        public bool? EstaActivo { get; set; }
        public int? IdGrupoNivel { get; set; }

        public string EscalafonDescContains { get; set; } 

    }
}
