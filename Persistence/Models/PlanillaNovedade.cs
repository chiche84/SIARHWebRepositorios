using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class PlanillaNovedade
    {
        public PlanillaNovedade()
        {
            SolicitudLegajos = new HashSet<SolicitudLegajo>();
        }

        public int IdPlanillaNov { get; set; }
        public int IdOrganizacion { get; set; }
        public int IdHistoriaOrg { get; set; }
        public DateTime FechaGeneracion { get; set; }
        public int Mes { get; set; }
        public int Año { get; set; }
        public bool? EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }
        public int? MatriculaMujeres { get; set; }
        public int? MatriculaVarones { get; set; }
        public bool EstaFinalizada { get; set; }
        public int? IdOrganizacionNivelEduc { get; set; }

        public virtual Organizacion Id { get; set; } = null!;
        public virtual OrganizacionNivelEducativo? IdOrganizacionNivelEducNavigation { get; set; }
        public virtual RefMe MesNavigation { get; set; } = null!;
        public virtual ICollection<SolicitudLegajo> SolicitudLegajos { get; set; }
    }
}
