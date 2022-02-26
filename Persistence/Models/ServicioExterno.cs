using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class ServicioExterno
    {
        public int IdServicioExterno { get; set; }
        public int? IdOrganizacion { get; set; }
        public int? IdHistoriaOrg { get; set; }
        public int? IdPersona { get; set; }
        public DateTime? FechaDesde { get; set; }
        public DateTime? FechaHasta { get; set; }
        public short? Años { get; set; }
        public short? Meses { get; set; }
        public short? Dias { get; set; }
        public DateTime? Fechaeliminacion { get; set; }
        public string? Observaciones { get; set; }
        public bool? EstaActivo { get; set; }

        public virtual Organizacion? Id { get; set; }
        public virtual Persona? IdPersonaNavigation { get; set; }
    }
}
