using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class SolicitudTurno
    {
        public SolicitudTurno()
        {
            SolicitudEstadosTurnos = new HashSet<SolicitudEstadosTurno>();
        }

        public int IdSolicitudTurno { get; set; }
        public int IdOrganismo { get; set; }
        public int IdHistoriaOrg { get; set; }
        public int IdPersona { get; set; }
        public int IdLicencia { get; set; }
        public DateTime? FechaPedido { get; set; }
        public DateTime? FechaTurno { get; set; }
        public DateTime? FechaNotificacion { get; set; }
        public string? MailContacto { get; set; }
        public bool? EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }
        public int IdTipoSolicitud { get; set; }
        public int IdEjercicio { get; set; }
        public int NumeroSolicitud { get; set; }

        public virtual Organizacion Id { get; set; } = null!;
        public virtual RefEjercicio IdEjercicioNavigation { get; set; } = null!;
        public virtual Licencium IdLicenciaNavigation { get; set; } = null!;
        public virtual Persona IdPersonaNavigation { get; set; } = null!;
        public virtual RefTipoSolicitud IdTipoSolicitudNavigation { get; set; } = null!;
        public virtual ICollection<SolicitudEstadosTurno> SolicitudEstadosTurnos { get; set; }
    }
}
