using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class OrganizacionTurnoView
    {
        public int IdOrganizacionTurno { get; set; }
        public int IdOrganizacion { get; set; }
        public int IdHistoriaOrg { get; set; }
        public int IdTurno { get; set; }
        public bool EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }
        public string TurnoDesc { get; set; } = null!;
    }
}
