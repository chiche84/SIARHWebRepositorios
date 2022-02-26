using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class RefAplicacion
    {
        public RefAplicacion()
        {
            AplicacionUsuarios = new HashSet<AplicacionUsuario>();
            RefPermisos = new HashSet<RefPermiso>();
        }

        public int IdAplicacion { get; set; }
        public string? AplicacionDesc { get; set; }
        public bool EstaActivo { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime? FechaEliminacion { get; set; }

        public virtual ICollection<AplicacionUsuario> AplicacionUsuarios { get; set; }
        public virtual ICollection<RefPermiso> RefPermisos { get; set; }
    }
}
