using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class RefMe
    {
        public RefMe()
        {
            PlanillaNovedades = new HashSet<PlanillaNovedade>();
        }

        public int IdMes { get; set; }
        public string? Mes { get; set; }

        public virtual ICollection<PlanillaNovedade> PlanillaNovedades { get; set; }
    }
}
