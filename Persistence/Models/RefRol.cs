using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class RefRol
    {
        public RefRol()
        {
            PermisoRols = new HashSet<PermisoRol>();
            UsuarioOrganizacionRols = new HashSet<UsuarioOrganizacionRol>();
        }

        public int IdRol { get; set; }
        public string? RolDesc { get; set; }
        public bool? EstaActivo { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime? FechaEliminacion { get; set; }

        public virtual ICollection<PermisoRol> PermisoRols { get; set; }
        public virtual ICollection<UsuarioOrganizacionRol> UsuarioOrganizacionRols { get; set; }
    }
}
