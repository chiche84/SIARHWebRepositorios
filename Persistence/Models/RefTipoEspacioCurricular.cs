using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    /// <summary>
    /// Tipo de espacio curricular. Ejemplo: asignatura, taller, etc.
    /// </summary>
    public partial class RefTipoEspacioCurricular
    {
        public RefTipoEspacioCurricular()
        {
            EspacioCurriculars = new HashSet<EspacioCurricular>();
        }

        /// <summary>
        /// Clave primaria, autoincrementable. Identificador de tipo de espacio curricular
        /// </summary>
        public int IdTipoEspacioCurricular { get; set; }
        /// <summary>
        /// Nombre del tipo de espacio curricular. Ejemplo: Asignatura, taller
        /// </summary>
        public string TipoEspacioCurricularDesc { get; set; } = null!;
        /// <summary>
        /// Campo para eliminacion logica. Valor 0 es igual a falso, valor 1 es igual a verdadero
        /// </summary>
        public bool? EstaActivo { get; set; }
        /// <summary>
        /// Fecha en la que deja de estar activo el tipo de espacio curricular
        /// </summary>
        public DateTime? FechaEliminacion { get; set; }

        public virtual ICollection<EspacioCurricular> EspacioCurriculars { get; set; }
    }
}
