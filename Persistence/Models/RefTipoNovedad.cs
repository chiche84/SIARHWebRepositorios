using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class RefTipoNovedad
    {
        public RefTipoNovedad()
        {
            Novedads = new HashSet<Novedad>();
        }

        public int IdTipoNovedad { get; set; }
        public string TipoNovedadDesc { get; set; } = null!;
        public bool ConGoceHaber { get; set; }
        public bool? EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }

        public virtual ICollection<Novedad> Novedads { get; set; }
    }
}
