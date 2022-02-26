using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class SolicitudEstadosView
    {
        public int IdEstadoSol { get; set; }
        public int IdSolicitudPlaza { get; set; }
        public int IdEstadoSolicitud { get; set; }
        public int IdCircuitoSol { get; set; }
        public string? Observacion { get; set; }
        public DateTime FechaEstado { get; set; }
        public string EstadoSolicitudDesc { get; set; } = null!;
        public int? Orden { get; set; }
        public string CircuitoSolDesc { get; set; } = null!;
    }
}
