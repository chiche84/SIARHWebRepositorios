using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class PlanEstudioCohorte
    {
        public PlanEstudioCohorte()
        {
            PlanUnidads = new HashSet<PlanUnidad>();
        }

        public int IdPlanEstudioCohorte { get; set; }
        public int IdPlanEstudio { get; set; }
        public int IdInstrumentoLegal { get; set; }
        public int? IdMotivoInsLegal { get; set; }
        public int? IdExpte { get; set; }
        public DateTime FechaDesde { get; set; }
        public DateTime? FechaHasta { get; set; }
        public bool? EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }

        public virtual InstrumentoLegal IdInstrumentoLegalNavigation { get; set; } = null!;
        public virtual RefMotivoInstLegalPe? IdMotivoInsLegalNavigation { get; set; }
        public virtual PlanEstudio IdPlanEstudioNavigation { get; set; } = null!;
        public virtual ICollection<PlanUnidad> PlanUnidads { get; set; }
    }
}
