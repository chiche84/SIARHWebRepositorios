using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class SolicitudLegajo
    {
        public SolicitudLegajo()
        {
            SolicitudDetalles = new HashSet<SolicitudDetalle>();
            SolicitudEstadosLegajos = new HashSet<SolicitudEstadosLegajo>();
        }

        public int IdSolicitudLegajo { get; set; }
        public int IdTipoSolicitud { get; set; }
        public int IdEjercicio { get; set; }
        public int NumeroSolicitud { get; set; }
        public int IdOrganizacion { get; set; }
        public int IdHistoriaOrg { get; set; }
        public bool? EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }
        /// <summary>
        /// Identificador de nivel educativo vinculado a la organización. 
        /// </summary>
        public int IdOrganizacionNivelEduc { get; set; }
        /// <summary>
        /// Clave foranea. Identificador de planilla de novedad en la que se incluyó la solicitud
        /// </summary>
        public int? IdPlanillaNov { get; set; }

        public virtual Organizacion Id { get; set; } = null!;
        public virtual RefEjercicio IdEjercicioNavigation { get; set; } = null!;
        public virtual OrganizacionNivelEducativo IdOrganizacionNivelEducNavigation { get; set; } = null!;
        public virtual PlanillaNovedade? IdPlanillaNovNavigation { get; set; }
        public virtual RefTipoSolicitud IdTipoSolicitudNavigation { get; set; } = null!;
        public virtual ICollection<SolicitudDetalle> SolicitudDetalles { get; set; }
        public virtual ICollection<SolicitudEstadosLegajo> SolicitudEstadosLegajos { get; set; }
    }
}
