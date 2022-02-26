using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class PermisoRol
    {
        /// <summary>
        /// Clave primaria, autoincrementable. Identificador de la relacion entre RefPermiso y RefRol.
        /// </summary>
        public int IdPermisoRol { get; set; }
        /// <summary>
        /// Clave foranea. Identificador de rol. Ejemplo: administrador.
        /// </summary>
        public int IdRol { get; set; }
        /// <summary>
        /// Clave foranea. Identificador de permiso. Ejemplo: crear expediente, enviar expediente.
        /// </summary>
        public int IdPermiso { get; set; }
        public int IdPermisoRel { get; set; }
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

        public virtual RefPermiso IdPermisoNavigation { get; set; } = null!;
        public virtual RefRol IdRolNavigation { get; set; } = null!;
    }
}
