using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class RefPermiso
    {
        public RefPermiso()
        {
            PermisoRols = new HashSet<PermisoRol>();
            UsuarioOrganizacionPermisos = new HashSet<UsuarioOrganizacionPermiso>();
        }

        public int IdPermiso { get; set; }
        public int IdPermisoRel { get; set; }
        public string PermisoDesc { get; set; } = null!;
        public bool? EstaActivo { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime? FechaEliminacion { get; set; }
        public int? IdAplicacion { get; set; }
        public bool? EstaMenu { get; set; }
        public string? Nivel1 { get; set; }
        public string? Nivel2 { get; set; }
        public int? Tipo { get; set; }

        public virtual RefAplicacion? IdAplicacionNavigation { get; set; }
        public virtual ICollection<PermisoRol> PermisoRols { get; set; }
        public virtual ICollection<UsuarioOrganizacionPermiso> UsuarioOrganizacionPermisos { get; set; }
    }
}
