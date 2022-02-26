using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    /// <summary>
    /// Relacion entre plan de estudio y espacio curricular. Un plan de estudio puede contener varios espacios curriculares y un espacio curricular puede pertenecer a varios planes de estudio
    /// </summary>
    public partial class PlanEspacio
    {
        public PlanEspacio()
        {
            PlanAsignaturas = new HashSet<PlanAsignatura>();
        }

        /// <summary>
        /// Clave primaria, autoincrementable. Identificador de la relacion entre plan de estudioy espacio curricular
        /// </summary>
        public int IdPlanEspacio { get; set; }
        /// <summary>
        /// Clave foranea. Identificador de plan de estudio
        /// </summary>
        public int IdPlanEstudio { get; set; }
        /// <summary>
        /// Clave foranea. Identificador del espacio curricular
        /// </summary>
        public int IdEspacioCurricular { get; set; }
        /// <summary>
        /// Año o grado en donde se dictará el espacio curricular
        /// </summary>
        public int? Anio { get; set; }
        /// <summary>
        /// Cantidad de horas que se dictan para un año y espacio curricular en particular 
        /// </summary>
        public int? CargaHoraria { get; set; }
        /// <summary>
        /// Clave para eliminación lógica. Valor 0 es igual a falso, valor 1 es igual a verdadero
        /// </summary>
        public bool? EstaActivo { get; set; }
        /// <summary>
        /// Fecha en la que deja de estar activa la relación entre el plan de estudio y el espacio curricular
        /// </summary>
        public DateTime? FechaEliminacion { get; set; }
        public string? PlanEspacioDesc { get; set; }
        /// <summary>
        /// Identificador de régimen de espacio curricular. Ej: Anual, 1er. cuatrimestre, 2do. cuatrimestre
        /// </summary>
        public int? IdRegimen { get; set; }

        public virtual EspacioCurricular IdEspacioCurricularNavigation { get; set; } = null!;
        public virtual PlanEstudio IdPlanEstudioNavigation { get; set; } = null!;
        public virtual RefRegimenEspCu? IdRegimenNavigation { get; set; }
        public virtual ICollection<PlanAsignatura> PlanAsignaturas { get; set; }
    }
}
