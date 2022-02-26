using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class CircuitoSolicitudLegajo
    {
        public CircuitoSolicitudLegajo()
        {
            CircuitoEtapaLegajos = new HashSet<CircuitoEtapaLegajo>();
        }

        public int IdCircuitoSolicitudLegajo { get; set; }
        public string CircuitoSolicitudLegajoDesc { get; set; } = null!;
        public int IdGrupoNivel { get; set; }
        public int IdTipoSolicitud { get; set; }
        public bool? EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }

        public virtual RefGrupoNivel IdGrupoNivelNavigation { get; set; } = null!;
        public virtual RefTipoSolicitud IdTipoSolicitudNavigation { get; set; } = null!;
        public virtual ICollection<CircuitoEtapaLegajo> CircuitoEtapaLegajos { get; set; }
    }
}
