using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class RefSumarioSancion
    {
        public RefSumarioSancion()
        {
            PersonaSumarioDictamen = new HashSet<PersonaSumarioDictaman>();
        }

        public int IdSancion { get; set; }
        public string SancionDesc { get; set; } = null!;
        public bool? EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }

        public virtual ICollection<PersonaSumarioDictaman> PersonaSumarioDictamen { get; set; }
    }
}
