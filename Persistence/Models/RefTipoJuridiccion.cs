using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class RefTipoJuridiccion
    {
        public RefTipoJuridiccion()
        {
            RefDescansos = new HashSet<RefDescanso>();
        }

        public int IdTipoJuridiccion { get; set; }
        public string TipoJuridiccionDesc { get; set; } = null!;
        public bool? EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }

        public virtual ICollection<RefDescanso> RefDescansos { get; set; }
    }
}
