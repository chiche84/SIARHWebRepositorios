using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class UsuarioOrganizacionRol
    {
        /// <summary>
        /// Clave primaria, autoincrementable. Identificador de la relacion entre UsuarioDependencia y RefRol.
        /// </summary>
        public int IdUsuarioOrganizacionRol { get; set; }
        /// <summary>
        /// Clave foranea. Identificador de un usuario en una dependencia.
        /// </summary>
        public int IdUsuarioOrganizacion { get; set; }
        /// <summary>
        /// Clave foranea. Identificador de rol.  Ejemplo: administrador.
        /// </summary>
        public int IdRol { get; set; }
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

        public virtual RefRol IdRolNavigation { get; set; } = null!;
        public virtual UsuarioOrganizacion IdUsuarioOrganizacionNavigation { get; set; } = null!;
    }
}
