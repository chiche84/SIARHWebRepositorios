using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class VwCircuitoSolicitudLegajo
    {
        public int IdSolicitudEstadoLegajo { get; set; }
        public int IdSolicitudLegajo { get; set; }
        public int IdEstadoSolicitudLegajo { get; set; }
        public int? IdCircuitoEtapaLegajo { get; set; }
        public string CircuitoEtapaLegajoDesc { get; set; } = null!;
        public string EstadoSolicitudDesc { get; set; } = null!;
        public string CircuitoSolicitudLegajoDesc { get; set; } = null!;
    }
}
