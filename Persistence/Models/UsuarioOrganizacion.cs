using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class UsuarioOrganizacion
    {
        public UsuarioOrganizacion()
        {
            UsuarioOrganizacionPermisos = new HashSet<UsuarioOrganizacionPermiso>();
            UsuarioOrganizacionRols = new HashSet<UsuarioOrganizacionRol>();
        }

        /// <summary>
        /// Clave primaria, autoincrementable. Identificador de la relacion entre Usuario y Dependencia.
        /// </summary>
        public int IdUsuarioOrganizacion { get; set; }
        /// <summary>
        /// Clave foranea. Identificador de usuario. Ejemplo: ptorres, hdiaz.
        /// </summary>
        public int IdUsuario { get; set; }
        /// <summary>
        /// Clave foranea. Identificador de dependencia.  Ejemplo: mesa de entrada, despacho.
        /// </summary>
        public int IdOrganizacion { get; set; }
        public int IdHistoriaOrg { get; set; }
        /// <summary>
        /// Campo para eliminación lógica. Valor 0 = Falso, Valor 1 = Verdadero.
        /// </summary>
        public bool? EstaActivo { get; set; }
        /// <summary>
        /// Fecha de alta.
        /// </summary>
        public DateTime FechaAlta { get; set; }
        /// <summary>
        /// Fecha de baja, modifica el estado del campo estaActivo.
        /// </summary>
        public DateTime? FechaEliminacion { get; set; }

        public virtual Organizacion Id { get; set; } = null!;
        public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
        public virtual ICollection<UsuarioOrganizacionPermiso> UsuarioOrganizacionPermisos { get; set; }
        public virtual ICollection<UsuarioOrganizacionRol> UsuarioOrganizacionRols { get; set; }
    }
}
