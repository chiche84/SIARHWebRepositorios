using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class _23MigracionSolicitudestado
    {
        public int IdSolicitudPlaza { get; set; }
        public int IdEstadoSolicitud { get; set; }
        public int IdCircuitoSol { get; set; }
        public string Observacion { get; set; } = null!;
        public DateTime FechaEstado { get; set; }
    }
}
