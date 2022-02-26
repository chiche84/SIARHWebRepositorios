using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    /// <summary>
    /// Un espacio curricular organiza y articula un conjunto de contenidos seleccionados para ser enseñados y aprendidos en un tiempo institucional determinado. Puede adoptar distintos formatos: asignatura, taller, seminario, laboratorio, proyecto  (idTipoEspacioCurricular) 
    /// </summary>
    public partial class EspacioCurricular
    {
        public EspacioCurricular()
        {
            EspacioAsignaturas = new HashSet<EspacioAsignatura>();
            PlanEspacios = new HashSet<PlanEspacio>();
        }

        /// <summary>
        /// Clave primaria, autoincrementable. Identificador del espacio que agrupa un conjunto de asignaturas
        /// </summary>
        public int IdEspacioCurricular { get; set; }
        /// <summary>
        /// Clave foranea. Identificador del tipo de espacio curricular al que pertenece. Ejemplo: Asignatura, taller
        /// </summary>
        public int? IdTipoEspacioCurricular { get; set; }
        /// <summary>
        /// Nombre del espacio curricular. Ejemplo: Lenguas extranjeras
        /// </summary>
        public string EspacioCurricularDesc { get; set; } = null!;
        /// <summary>
        /// Campo para eliminación lógica. Valor 0 es igual a falso, valor 1 es igual a verdadero
        /// </summary>
        public bool? EstaActivo { get; set; }
        /// <summary>
        /// Fecha en la que deja estar activo el espacio curricular
        /// </summary>
        public DateTime? FechaEliminacion { get; set; }

        public virtual RefTipoEspacioCurricular? IdTipoEspacioCurricularNavigation { get; set; }
        public virtual ICollection<EspacioAsignatura> EspacioAsignaturas { get; set; }
        public virtual ICollection<PlanEspacio> PlanEspacios { get; set; }
    }
}
