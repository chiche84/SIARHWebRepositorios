using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    /// <summary>
    /// Describe el tipo de goce de haberes, ej.: Con Goce de Haberes, Sin Goce de Haberes.
    /// </summary>
    public partial class RefTipoGoceHaber
    {
        public RefTipoGoceHaber()
        {
            Licencia = new HashSet<Licencium>();
        }

        /// <summary>
        /// Clave primaria, autoincrementable. Identificador del tipo de goce de haberes.
        /// </summary>
        public int IdTipoGoceHaber { get; set; }
        /// <summary>
        /// Describe el tipo de goce de haberes, ej.: Con Goce de Haberes, Sin Goce de Haberes.
        /// </summary>
        public string TipoGoceHaberDesc { get; set; } = null!;
        /// <summary>
        /// Describe la abreviatura del tipo de goce de haberes, ej.: CGH, SGH.
        /// </summary>
        public string Abreviatura { get; set; } = null!;
        public bool? EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }

        public virtual ICollection<Licencium> Licencia { get; set; }
    }
}
