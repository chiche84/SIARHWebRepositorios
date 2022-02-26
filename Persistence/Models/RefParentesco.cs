using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    /// <summary>
    /// Relacion o vinculo de personas. Ejemplo: madre, padre, conyuge, etc.
    /// </summary>
    public partial class RefParentesco
    {
        /// <summary>
        /// Clave primaria, autoincremental. Identificador de parentesco.
        /// </summary>
        public int IdParentesco { get; set; }
        /// <summary>
        /// Descripcion de parentesco.
        /// </summary>
        public string ParentescoDesc { get; set; } = null!;
        public bool? EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }
    }
}
