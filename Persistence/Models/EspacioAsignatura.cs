using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    /// <summary>
    /// Relacion entre espacio curricular y asignatura. Un espacio curricular puede contener a muchas asignaturas y una asignatura puede pertenecer a varios espacios curriculares
    /// 
    /// </summary>
    public partial class EspacioAsignatura
    {
        public EspacioAsignatura()
        {
            ReqSolicitudPrimaria = new HashSet<ReqSolicitudPrimarium>();
        }

        /// <summary>
        /// Clave primaria, autoincrementable. Identificador de la relacion en tre Espacio curricular y la  Asignatura
        /// </summary>
        public int IdEspacioAsignatura { get; set; }
        /// <summary>
        /// Clave foranea. Identificador de espacio curricular. Ejemplo: Lenguas extranjeras
        /// </summary>
        public int IdEspacioCurricular { get; set; }
        /// <summary>
        /// Clave foranea. Identificador de asignatura. Ejemplo: Ingles, Francés
        /// </summary>
        public int IdAsignatura { get; set; }
        /// <summary>
        /// Campo para eliminación lógica. Valor 0 es igual a falso, valor 1 es igual a verdadero
        /// </summary>
        public bool? EstaActivo { get; set; }
        /// <summary>
        /// Fecha en la que deja de estar activa la relación en tre el espacio curricular y la asignatura
        /// </summary>
        public DateTime? FechaEliminacion { get; set; }

        public virtual RefAsignatura IdAsignaturaNavigation { get; set; } = null!;
        public virtual EspacioCurricular IdEspacioCurricularNavigation { get; set; } = null!;
        public virtual ICollection<ReqSolicitudPrimarium> ReqSolicitudPrimaria { get; set; }
    }
}
