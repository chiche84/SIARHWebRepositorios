using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class RefTipoDescanso
    {
        public RefTipoDescanso()
        {
            RefDescansos = new HashSet<RefDescanso>();
        }

        public int IdTipoDescanso { get; set; }
        public string TipoDescansoDesc { get; set; } = null!;
        public bool? EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }

        public virtual ICollection<RefDescanso> RefDescansos { get; set; }
    }
}
