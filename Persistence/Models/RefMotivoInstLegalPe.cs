using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class RefMotivoInstLegalPe
    {
        public RefMotivoInstLegalPe()
        {
            PlanEstudioCohortes = new HashSet<PlanEstudioCohorte>();
        }

        public int IdMotivoInstLegal { get; set; }
        public string MotivoInstLegalDesc { get; set; } = null!;
        public bool? EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }

        public virtual ICollection<PlanEstudioCohorte> PlanEstudioCohortes { get; set; }
    }
}
