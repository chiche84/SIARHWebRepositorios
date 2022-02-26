using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class SolicitudEstadosTurno
    {
        public int IdSolicitudEstadoTurno { get; set; }
        public int IdSolicitudTurno { get; set; }
        public int IdEstadoSolicitud { get; set; }
        public string? Observacion { get; set; }
        public DateTime FechaEstado { get; set; }
        public bool? EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }

        public virtual RefEstadoSolicitud IdEstadoSolicitudNavigation { get; set; } = null!;
        public virtual SolicitudTurno IdSolicitudTurnoNavigation { get; set; } = null!;
    }
}
