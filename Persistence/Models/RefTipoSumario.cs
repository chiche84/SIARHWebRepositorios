using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class RefTipoSumario
    {
        public RefTipoSumario()
        {
            PersonaSumarios = new HashSet<PersonaSumario>();
        }

        public int IdTipoSumario { get; set; }
        public string TipoSumarioDesc { get; set; } = null!;
        public bool? EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }

        public virtual ICollection<PersonaSumario> PersonaSumarios { get; set; }
    }
}
