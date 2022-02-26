using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    /// <summary>
    /// SIAC. Requerimientos de plazas pertenecientes a una solicitud (nivel primario) 
    /// 
    /// </summary>
    public partial class ReqSolicitudPrimarium
    {
        /// <summary>
        /// Codigo identificador de solicitud
        /// </summary>
        public int IdSolicitud { get; set; }
        /// <summary>
        /// Codigo identificador de cada requerimiento de una solicitud
        /// </summary>
        public int IdRequerimiento { get; set; }
        /// <summary>
        /// Cantidad de cargos solicitados de una determinada categoría
        /// </summary>
        public int? Cantidad { get; set; }
        /// <summary>
        /// Codigo identificador de categoría (registrada en la ley de presupuesto)
        /// </summary>
        public int IdCategoriaPresupuesto { get; set; }
        /// <summary>
        /// Codigo identificador de cargo funcional
        /// </summary>
        public int IdCargoFuncional { get; set; }
        public int? IdPlanUnidad { get; set; }
        /// <summary>
        /// Clave foranea, Identificador de division. Campo opcional
        /// </summary>
        public int? IdDivision { get; set; }
        /// <summary>
        /// Codigo identificador de materia
        /// </summary>
        public int? IdEspacioAsignatura { get; set; }
        /// <summary>
        /// Codigo identificador de organizacion turno
        /// </summary>
        public int? IdOrganizacionTurno { get; set; }
        /// <summary>
        /// Identificador de Organización en la que se comparte el cargo
        /// </summary>
        public int? IdOrgCompartida { get; set; }
        /// <summary>
        /// Codigo identificador de jornada (simple, completa, etc.)
        /// </summary>
        public int? IdJornada { get; set; }
        public bool? CargaMateria { get; set; }
        /// <summary>
        /// Caracter del cargo, puede ser definitov o provisional
        /// </summary>
        public string? Caracter { get; set; }
        /// <summary>
        /// Fecha de inidio del periodo de habilitacion del cargo
        /// </summary>
        public DateTime FechaDesde { get; set; }
        /// <summary>
        /// Fecha de fin de habilitacion del cargo
        /// </summary>
        public DateTime? FechaHasta { get; set; }
        public string? Observacion { get; set; }
        /// <summary>
        /// Clave foranea, identificador de estado en que se puede encontrar un requerimiento. Ejemplo: autorizado, habilitado. rechazado, etc.
        /// </summary>
        public int IdEstadoRequerimiento { get; set; }
        /// <summary>
        /// Descirpcion detallada acera del estado del requerimiento
        /// </summary>
        public string? ObsEstado { get; set; }
        /// <summary>
        /// Indica si es educación formal o no formal
        /// </summary>
        public string? PartidaTeducacion { get; set; }
        public int? Cupof { get; set; }
        public int? PCupof { get; set; }
        public bool? AdmiteSuplente { get; set; }
        public bool? CobraIncentivo { get; set; }
        public int? IdSistemaEducativo { get; set; }
        public int? IdRegimenLaboral { get; set; }
        public int? IdFinanciamiento { get; set; }
        public int? IdRegimenSalarial { get; set; }
        public bool EstaActivo { get; set; }

        public virtual CargoFuncional IdCargoFuncionalNavigation { get; set; } = null!;
        public virtual Division? IdDivisionNavigation { get; set; }
        public virtual EspacioAsignatura? IdEspacioAsignaturaNavigation { get; set; }
        public virtual RefEstadoSolicitud IdEstadoRequerimientoNavigation { get; set; } = null!;
        public virtual RefFinanciamiento? IdFinanciamientoNavigation { get; set; }
        public virtual RefJornadum? IdJornadaNavigation { get; set; }
        public virtual PlanUnidad? IdPlanUnidadNavigation { get; set; }
        public virtual RefRegimenLaboral? IdRegimenLaboralNavigation { get; set; }
        public virtual RefRegimenSalarial? IdRegimenSalarialNavigation { get; set; }
        public virtual RefSistemaEducativo? IdSistemaEducativoNavigation { get; set; }
    }
}
