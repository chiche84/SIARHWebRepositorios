using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class TableroOrganizacionView
    {
        public int IdTableroOrganizacion { get; set; }
        public int IdOrganizacionNivelEducativo { get; set; }
        public int IdOrganizacionTurno { get; set; }
        public int IdEjercicio { get; set; }
        public int IdOrganizacion { get; set; }
        public int IdHistoriaOrg { get; set; }
        public string OrganizacionDesc { get; set; } = null!;
        public string NivelEducativoDesc { get; set; } = null!;
        public string GrupoDesc { get; set; } = null!;
        public string TurnoDesc { get; set; } = null!;
        public bool EstaActivo { get; set; }
    }
}
