using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class PlanUnidadView
    {
        public int IdPlanUnidad { get; set; }
        public int IdOrganizacionNivelEduc { get; set; }
        public bool EstaActivo { get; set; }
        public int IdOrganizacion { get; set; }
        public int IdNivelEducativo { get; set; }
        public string NivelEducativoDesc { get; set; } = null!;
        public string PlanEstudioDesc { get; set; } = null!;
        public int IdHistoriaOrg { get; set; }
        public int IdPlanEstudio { get; set; }
    }
}
