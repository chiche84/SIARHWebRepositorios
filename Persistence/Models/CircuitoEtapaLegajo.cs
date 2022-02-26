using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class CircuitoEtapaLegajo
    {
        public CircuitoEtapaLegajo()
        {
            SolicitudDetalles = new HashSet<SolicitudDetalle>();
            SolicitudEstadosLegajos = new HashSet<SolicitudEstadosLegajo>();
        }

        public int IdCircuitoEtapaLegajo { get; set; }
        public int IdCircuitoSolicitudLegajo { get; set; }
        public int? IdOrganizacion { get; set; }
        public int? IdHistoriaOrg { get; set; }
        public string CircuitoEtapaLegajoDesc { get; set; } = null!;
        public byte Orden { get; set; }
        public bool? EstaHabilitado { get; set; }
        public bool? EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }

        public virtual Organizacion? Id { get; set; }
        public virtual CircuitoSolicitudLegajo IdCircuitoSolicitudLegajoNavigation { get; set; } = null!;
        public virtual ICollection<SolicitudDetalle> SolicitudDetalles { get; set; }
        public virtual ICollection<SolicitudEstadosLegajo> SolicitudEstadosLegajos { get; set; }
    }
}
