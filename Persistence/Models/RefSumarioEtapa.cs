using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class RefSumarioEtapa
    {
        public RefSumarioEtapa()
        {
            PersonaSumarioInstLegals = new HashSet<PersonaSumarioInstLegal>();
        }

        public int IdSumarioEtapa { get; set; }
        public string SumarioEtapaDesc { get; set; } = null!;
        public bool? EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }

        public virtual ICollection<PersonaSumarioInstLegal> PersonaSumarioInstLegals { get; set; }
    }
}
