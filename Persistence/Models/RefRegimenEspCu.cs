using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class RefRegimenEspCu
    {
        public RefRegimenEspCu()
        {
            PlanEspacios = new HashSet<PlanEspacio>();
        }

        public int IdRegimen { get; set; }
        public string RegimenDesc { get; set; } = null!;
        public bool? EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }

        public virtual ICollection<PlanEspacio> PlanEspacios { get; set; }
    }
}
