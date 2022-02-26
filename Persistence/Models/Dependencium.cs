using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class Dependencium
    {
        public int IdDependencia { get; set; }
        public string DependenciaDesc { get; set; } = null!;
        public string Direccion { get; set; } = null!;
        public int? IdDependenciaPadre { get; set; }
        public bool EsInterna { get; set; }
        public bool? EstaActivo { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime? FechaEliminacion { get; set; }
        public int IdOrganizacion { get; set; }
        public int IdHistoriaOrg { get; set; }
        public bool? ParaGdocs { get; set; }
        public int? TieneHijo { get; set; }
    }
}
