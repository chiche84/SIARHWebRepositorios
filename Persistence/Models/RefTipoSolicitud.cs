using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class RefTipoSolicitud
    {
        public RefTipoSolicitud()
        {
            CircuitoSolicitudLegajos = new HashSet<CircuitoSolicitudLegajo>();
            CircuitoSolicitudPlazas = new HashSet<CircuitoSolicitudPlaza>();
            SolicitudLegajos = new HashSet<SolicitudLegajo>();
            SolicitudPlazas = new HashSet<SolicitudPlaza>();
            SolicitudTurnos = new HashSet<SolicitudTurno>();
        }

        public int IdTipoSolicitud { get; set; }
        public string TipoSolicitudDesc { get; set; } = null!;
        public bool? EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }

        public virtual ICollection<CircuitoSolicitudLegajo> CircuitoSolicitudLegajos { get; set; }
        public virtual ICollection<CircuitoSolicitudPlaza> CircuitoSolicitudPlazas { get; set; }
        public virtual ICollection<SolicitudLegajo> SolicitudLegajos { get; set; }
        public virtual ICollection<SolicitudPlaza> SolicitudPlazas { get; set; }
        public virtual ICollection<SolicitudTurno> SolicitudTurnos { get; set; }
    }
}
