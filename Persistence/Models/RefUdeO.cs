using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    /// <summary>
    /// Unidad de Organizacion. Ejemplo. Ministerio de Educacion (F1), Dirección General de Administración (F1A)
    /// </summary>
    public partial class RefUdeO
    {
        public RefUdeO()
        {
            RefUdeOxEjers = new HashSet<RefUdeOxEjer>();
        }

        /// <summary>
        /// Clave primaria, autoincrementable. Identificador de Unidad de Organizacion
        /// </summary>
        public int IdUdeO { get; set; }
        /// <summary>
        /// Descripcion de la unidad de organizacion
        /// </summary>
        public string UdeoDesc { get; set; } = null!;
        /// <summary>
        /// Campo para eliminacion logica. Valor 0 es igual a false, valor 1 es igual a verdadero
        /// </summary>
        public bool? EstaActivo { get; set; }
        /// <summary>
        /// Fecha en la que deja de estar activa la Unidad de Organizacion
        /// </summary>
        public DateTime? FechaEliminacion { get; set; }

        public virtual ICollection<RefUdeOxEjer> RefUdeOxEjers { get; set; }
    }
}
