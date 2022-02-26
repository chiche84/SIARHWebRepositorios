using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    /// <summary>
    /// Diseño curricular de enseñanza 
    /// </summary>
    public partial class PlanEstudio
    {
        public PlanEstudio()
        {
            InverseIdPlanEstudioBaseNavigation = new HashSet<PlanEstudio>();
            PlanEspacios = new HashSet<PlanEspacio>();
            PlanEstudioCohortes = new HashSet<PlanEstudioCohorte>();
        }

        /// <summary>
        /// Clave primaria, autoincrementable.Codigo identificador de plan de estudio
        /// </summary>
        public int IdPlanEstudio { get; set; }
        /// <summary>
        /// Clave foranea, especialidad del plan de estudio. Ej: computación, orientación docente, electrónica, etc.
        /// </summary>
        public int IdEspecialidad { get; set; }
        /// <summary>
        /// Nombre del plan de Estudio. Ej: BACHILLER CON ORIENTACION EN COMPUTACION
        /// </summary>
        public string PlanEstudioDesc { get; set; } = null!;
        /// <summary>
        /// Duración en años del plan de estudio
        /// </summary>
        public int? Duracion { get; set; }
        /// <summary>
        /// Campo para eliminación lógica
        /// </summary>
        public bool? EstaActivo { get; set; }
        /// <summary>
        /// Fecha en la que deja de estar activo el registro
        /// </summary>
        public DateTime? FechaEliminacion { get; set; }
        public bool? EstaVigente { get; set; }
        public int? IdPlanEstudioBase { get; set; }
        public int IdNivelEducativo { get; set; }

        public virtual RefEspecialidad IdEspecialidadNavigation { get; set; } = null!;
        public virtual RefNivelEducativo IdNivelEducativoNavigation { get; set; } = null!;
        public virtual PlanEstudio? IdPlanEstudioBaseNavigation { get; set; }
        public virtual ICollection<PlanEstudio> InverseIdPlanEstudioBaseNavigation { get; set; }
        public virtual ICollection<PlanEspacio> PlanEspacios { get; set; }
        public virtual ICollection<PlanEstudioCohorte> PlanEstudioCohortes { get; set; }
    }
}
