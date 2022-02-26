using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    /// <summary>
    /// Orientacion o estudio especifico de una rama de la educacion. Ejemplo: Computacion, orientacion docente, etc.
    /// </summary>
    public partial class RefEspecialidad
    {
        public RefEspecialidad()
        {
            PlanEstudios = new HashSet<PlanEstudio>();
        }

        /// <summary>
        /// Clave primaria, autoincrementable. Identificador de especialidad
        /// </summary>
        public int IdEspecialidad { get; set; }
        /// <summary>
        /// Nombre de la especialidad u orientación del plan de estudio. Ejemplo: Bachillerato comun, computación
        /// </summary>
        public string EspecialidadDesc { get; set; } = null!;
        /// <summary>
        /// Campo de eliminacion lógica
        /// </summary>
        public bool? EstaActivo { get; set; }
        /// <summary>
        /// Fecha en la que deja de estar activa la especialidad
        /// </summary>
        public DateTime? FechaEliminacion { get; set; }

        public virtual ICollection<PlanEstudio> PlanEstudios { get; set; }
    }
}
