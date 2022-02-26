using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class CircuitoEtapaLegajoEnUsoActualView
    {
        public int IdCircuitoEtapaLegajo { get; set; }
        public int IdCircuitoSolicitudLegajo { get; set; }
        public int IdOrganizacion { get; set; }
        public int IdHistoriaOrg { get; set; }
        public string CircuitoEtapaLegajoDesc { get; set; } = null!;
        public byte Orden { get; set; }
        public bool EstaHabilitado { get; set; }
        public bool EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }
    }
}
