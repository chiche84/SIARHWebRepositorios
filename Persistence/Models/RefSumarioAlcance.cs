using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class RefSumarioAlcance
    {
        public RefSumarioAlcance()
        {
            PersonaSumarioDictamen = new HashSet<PersonaSumarioDictaman>();
        }

        public int IdSumarioAlcance { get; set; }
        public string AlcandeDesc { get; set; } = null!;
        public bool? EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }

        public virtual ICollection<PersonaSumarioDictaman> PersonaSumarioDictamen { get; set; }
    }
}
