using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    /// <summary>
    /// Ítems o cargos de una solicitud de habilitación de plazas
    /// </summary>
    public partial class SolicitudPlazaSitExt
    {
        /// <summary>
        /// Campo cñave autoincremental
        /// </summary>
        public int IdSolicitudPlazaSitExt { get; set; }
        /// <summary>
        /// Identificador del detalle de solicitud de situación extraordinaria para la cual se genera la plaza.
        /// </summary>
        public int IdSolicitudDetalle { get; set; }
        /// <summary>
        /// Identificador de tipo de plaza
        /// </summary>
        public int IdTipoPlaza { get; set; }
        /// <summary>
        /// Identificador de plaza para la cual se generará un servicio
        /// </summary>
        public int? IdPlaza { get; set; }
        /// <summary>
        /// Identificadoe de cargo salarial
        /// </summary>
        public int IdCargoSalarial { get; set; }
        /// <summary>
        /// Identificador de la función se de desempeñará en el cargo o plaza
        /// </summary>
        public int IdCargoFuncional { get; set; }
        public string? FuncionExtra { get; set; }
        /// <summary>
        /// Identificador de una unidad académica, es decir plan de estudio dentro de una organizaicón para un determinado nivel educativo. 
        /// </summary>
        public int? IdPlanUnidad { get; set; }
        /// <summary>
        /// Identificador de asignatura dentro un plan de estudio de una organización
        /// </summary>
        public int? IdPlanAsignatura { get; set; }
        /// <summary>
        /// Divisón de una organización para un pland e estudio en particular
        /// </summary>
        public int? IdDivision { get; set; }
        /// <summary>
        /// Identificador de turno dentro de una organización
        /// </summary>
        public int? IdOrganizacionTurno { get; set; }
        /// <summary>
        /// cantidad de horas en caso de tratarse de una cargo tipo hs.
        /// </summary>
        public int? CantidadHs { get; set; }
        /// <summary>
        /// Identificador de la temporalidad o caracter de la palza- Ejemplo: 1 - definitivo, 2-provisional
        /// </summary>
        public int IdTemporalidad { get; set; }
        /// <summary>
        /// Campo para determinar si al finalziar el período de habilitación de la plaza ésta será dada de baja de forma automática.
        /// </summary>
        public bool? BajaAutomatica { get; set; }
        /// <summary>
        /// Fecha desde la que se solicita la habilitación  de la plaza
        /// </summary>
        public DateTime FechaHabilitacion { get; set; }
        /// <summary>
        /// Fecha de término del período de habilitación de la plaza
        /// </summary>
        public DateTime? FechaTermino { get; set; }
        /// <summary>
        /// Fecha de creación del cargo 
        /// </summary>
        public DateTime? FechaCreacion { get; set; }
        /// <summary>
        /// Identificador de motivo de creación. Ejemplo POF, NO POF
        /// </summary>
        public int? IdMotivoCreacion { get; set; }
        /// <summary>
        /// Instrumento legal de creación
        /// </summary>
        public int? IdInstrumentoLegalCreacion { get; set; }
        /// <summary>
        /// Clave foranea, identificador del expediente con el que se tramita la creacion de la plaza extraordinaria.
        /// </summary>
        public int? IdExpteCreacion { get; set; }
        /// <summary>
        /// Instrumento legal de baja
        /// </summary>
        public int? IdInstrumentoLegalBaja { get; set; }
        /// <summary>
        /// Identificador de motivo de baja de la plaza. Ejemplo: termino de periodo de habilitacion
        /// </summary>
        public int? IdMotivoBaja { get; set; }
        /// <summary>
        /// Indica si es educación formal o no formal
        /// </summary>
        public int? IdSistemaEducativo { get; set; }
        /// <summary>
        /// Docente, no docente,  contrato de servicio, etc.
        /// </summary>
        public int? IdRegimenLaboral { get; set; }
        /// <summary>
        /// Cargo, horas
        /// </summary>
        public int? IdRegimenSalarial { get; set; }
        /// <summary>
        /// Provincia, nacion, municipalidad
        /// </summary>
        public int? IdFinanciamiento { get; set; }
        /// <summary>
        /// Indica si la plaza admite suplencias
        /// </summary>
        public bool? AdmiteSuplente { get; set; }
        /// <summary>
        /// Indica si la plaza habilita el cobro de incentivo
        /// </summary>
        public bool? CobraIncentivo { get; set; }
        /// <summary>
        /// Intrapresupeustaria, extrapresupeustaria
        /// </summary>
        public int? IdAfectacion { get; set; }
        public string? Observacion { get; set; }
        /// <summary>
        /// Campo para eliminación lógica
        /// </summary>
        public bool EstaActivo { get; set; }
        /// <summary>
        /// Fecha de eliminación lógica
        /// </summary>
        public DateTime? FechaEliminacion { get; set; }

        public virtual RefAfectacion? IdAfectacionNavigation { get; set; }
        public virtual CargoFuncional IdCargoFuncionalNavigation { get; set; } = null!;
        public virtual CargoSalarial IdCargoSalarialNavigation { get; set; } = null!;
        public virtual Division? IdDivisionNavigation { get; set; }
        public virtual RefFinanciamiento? IdFinanciamientoNavigation { get; set; }
        public virtual InstrumentoLegal? IdInstrumentoLegalBajaNavigation { get; set; }
        public virtual InstrumentoLegal? IdInstrumentoLegalCreacionNavigation { get; set; }
        public virtual OrganizacionTurno? IdOrganizacionTurnoNavigation { get; set; }
        public virtual PlanAsignatura? IdPlanAsignaturaNavigation { get; set; }
        public virtual PlanUnidad? IdPlanUnidadNavigation { get; set; }
        public virtual RefRegimenLaboral? IdRegimenLaboralNavigation { get; set; }
        public virtual RefRegimenSalarial? IdRegimenSalarialNavigation { get; set; }
        public virtual RefSistemaEducativo? IdSistemaEducativoNavigation { get; set; }
        public virtual RefTemporalidad IdTemporalidadNavigation { get; set; } = null!;
        public virtual RefTipoPlaza IdTipoPlazaNavigation { get; set; } = null!;
    }
}
