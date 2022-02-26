using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    /// <summary>
    /// Asignaturas
    /// </summary>
    public partial class RefAsignatura
    {
        public RefAsignatura()
        {
            EspacioAsignaturas = new HashSet<EspacioAsignatura>();
            PlanAsignaturas = new HashSet<PlanAsignatura>();
        }

        /// <summary>
        /// Clave primaria, autoincrementable. Identificador de la asignatura
        /// </summary>
        public int IdAsignatura { get; set; }
        /// <summary>
        /// Nombre descriptivo de la asignatura
        /// </summary>
        public string AsignaturaDesc { get; set; } = null!;
        /// <summary>
        /// Campo para eliminación lógica. Valor 0 es igual a falso, valor 1 es igual a verdadero
        /// </summary>
        public bool? EstaActivo { get; set; }
        /// <summary>
        /// Fecha en la que deja de estar activa la asignatura
        /// </summary>
        public DateTime? FechaEliminacion { get; set; }

        public virtual ICollection<EspacioAsignatura> EspacioAsignaturas { get; set; }
        public virtual ICollection<PlanAsignatura> PlanAsignaturas { get; set; }
    }
}
