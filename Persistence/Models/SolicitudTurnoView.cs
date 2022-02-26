using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class SolicitudTurnoView
    {
        public string Nombre { get; set; } = null!;
        public string Apellido { get; set; } = null!;
        public int? Documento { get; set; }
        public string OrganizacionDesc { get; set; } = null!;
        public int? Cue { get; set; }
        public string NumeroArticulo { get; set; } = null!;
        public DateTime? FechaPedido { get; set; }
        public DateTime? FechaTurno { get; set; }
        public DateTime? FechaNotificacion { get; set; }
        public string? MailContacto { get; set; }
        public bool EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }
        public string? Cuil { get; set; }
        public int IdSolicitudTurno { get; set; }
        public int IdOrganismo { get; set; }
        public int IdHistoriaOrg { get; set; }
        public int IdPersona { get; set; }
        public int IdLicencia { get; set; }
        public int? IdTipoDocumento { get; set; }
        public int IdOrganizacion { get; set; }
        public int Expr1 { get; set; }
        public int Expr2 { get; set; }
    }
}
