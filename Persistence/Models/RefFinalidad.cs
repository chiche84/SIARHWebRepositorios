using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    /// <summary>
    /// Propio del presupuesto. Clasificacion de gastos por finalidad. Ejemplo: Cultura y educacion, adminsitracion general
    /// </summary>
    public partial class RefFinalidad
    {
        public RefFinalidad()
        {
            RefFinalidadxEjers = new HashSet<RefFinalidadxEjer>();
        }

        /// <summary>
        /// Clave primaria, NO autoincrementable. Identificador de la finalidad a la cual va dirigida el presupuesto
        /// </summary>
        public int IdFinalidad { get; set; }
        /// <summary>
        /// Descripcion de la finalidad segun presupuesto. Ejemplo: 3-Administración general; 5-Cultura y educación
        /// </summary>
        public string FinalidadDesc { get; set; } = null!;
        /// <summary>
        /// Indica si esta activa o no la finalidad
        /// </summary>
        public bool? EstaActivo { get; set; }
        /// <summary>
        /// Fecha en la que deja de estar activa la finalidad
        /// </summary>
        public DateTime? FechaEliminacion { get; set; }

        public virtual ICollection<RefFinalidadxEjer> RefFinalidadxEjers { get; set; }
    }
}
