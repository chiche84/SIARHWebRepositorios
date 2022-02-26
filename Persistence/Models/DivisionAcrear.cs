using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    /// <summary>
    /// Registra las divisiones a crear, solicitidas por los establecimientos educativos en la solicitud de cargos
    /// </summary>
    public partial class DivisionAcrear
    {
        /// <summary>
        /// Clave primaria, autoincrementable.Codigo identificador de division.
        /// </summary>
        public int IdDivisionAcrear { get; set; }
        /// <summary>
        /// Clave foranea de Plan Unidad
        /// </summary>
        public int IdPlanUnidad { get; set; }
        /// <summary>
        /// Clave foranea de la tabla organizacion-turno
        /// </summary>
        public int IdOrganizacionTurno { get; set; }
        /// <summary>
        /// Descripción del curso (año o grupo)
        /// </summary>
        public string Curso { get; set; } = null!;
        /// <summary>
        /// Descripcion de la division (sección)
        /// </summary>
        public string DivisionDesc { get; set; } = null!;
        /// <summary>
        /// Identifica si el registro esta activo.
        /// </summary>
        public bool? EstaActivo { get; set; }
        /// <summary>
        /// Identifica si la division es un grupo. (1 = SI, 0 = NO)
        /// </summary>
        public bool EsGrupo { get; set; }
        /// <summary>
        /// Almacena la fecha de alta de la division.
        /// </summary>
        public DateTime FechaAlta { get; set; }
        /// <summary>
        /// Almacena la fecha de baja de la division.
        /// </summary>
        public DateTime? FechaEliminacion { get; set; }

        public virtual OrganizacionTurno IdOrganizacionTurnoNavigation { get; set; } = null!;
        public virtual PlanUnidad IdPlanUnidadNavigation { get; set; } = null!;
    }
}
