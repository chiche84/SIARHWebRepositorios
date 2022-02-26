using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    /// <summary>
    /// Ítems o cargos de una solicitud de habilitación de plazas
    /// </summary>
    public partial class SolicitudPlazaDetalle
    {
        public SolicitudPlazaDetalle()
        {
            PlazaTransferida = new HashSet<PlazaTransferidum>();
            Plazas = new HashSet<Plaza>();
            SolicitudPlazaDesignacions = new HashSet<SolicitudPlazaDesignacion>();
        }

        public int IdSolicitudPlazaDetalle { get; set; }
        /// <summary>
        /// Identificador de solicitud
        /// </summary>
        public int IdSolicitudPlaza { get; set; }
        public int IdTipoPlaza { get; set; }
        /// <summary>
        /// Código único de plaza orgánica funcional - requerido si se trata de una renovación, 0 si se trata de una plaza nueva
        /// </summary>
        public int? IdPlaza { get; set; }
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
        /// cantidad de horas en caso de tratassrse de una cargo tipo hs.
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
        public int? IdInstrumentoLegalCreacion { get; set; }
        /// <summary>
        /// Clave foranea, identificador del expediente con el que se tramita la solicitud.
        /// </summary>
        public int? IdExpteCreacion { get; set; }
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
        public bool? CobraIncentivo { get; set; }
        /// <summary>
        /// Intrapresupeustaria, extrapresupeustaria
        /// </summary>
        public int? IdAfectacion { get; set; }
        public string? Observacion { get; set; }
        public bool? EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }
        public int? IdPaquete { get; set; }
        public bool? EsCabeceraDePaquete { get; set; }
        /// <summary>
        /// Estado de la plaza detalle de la solicitud. Ejemplo: creada, presentada, aprobada, rechazada,
        /// </summary>
        public int? IdEstadoPlaza { get; set; }
        /// <summary>
        /// Observaciones sobre el estado de la plaza detalle de la solicitud
        /// </summary>
        public string? ObsEstadoPlaza { get; set; }
        public int? IdCircuitoSol { get; set; }
        /// <summary>
        /// Acción realziada sobre la plaza solicitda, ins: agregar; upd: modificar: nch: sin cambios; del: eliminar
        /// </summary>
        public string? AccionPlaza { get; set; }
        public int? IdUsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public int? IdTerminoLectivo { get; set; }

        public virtual RefAfectacion? IdAfectacionNavigation { get; set; }
        public virtual CargoFuncional IdCargoFuncionalNavigation { get; set; } = null!;
        public virtual CargoSalarial IdCargoSalarialNavigation { get; set; } = null!;
        public virtual CircuitoSolicitudPlaza? IdCircuitoSolNavigation { get; set; }
        public virtual Division? IdDivisionNavigation { get; set; }
        public virtual RefEstadoSolicitud? IdEstadoPlazaNavigation { get; set; }
        public virtual RefFinanciamiento? IdFinanciamientoNavigation { get; set; }
        public virtual InstrumentoLegal? IdInstrumentoLegalBajaNavigation { get; set; }
        public virtual InstrumentoLegal? IdInstrumentoLegalCreacionNavigation { get; set; }
        public virtual OrganizacionTurno? IdOrganizacionTurnoNavigation { get; set; }
        public virtual PlanAsignatura? IdPlanAsignaturaNavigation { get; set; }
        public virtual PlanUnidad? IdPlanUnidadNavigation { get; set; }
        public virtual RefRegimenLaboral? IdRegimenLaboralNavigation { get; set; }
        public virtual RefRegimenSalarial? IdRegimenSalarialNavigation { get; set; }
        public virtual RefSistemaEducativo? IdSistemaEducativoNavigation { get; set; }
        public virtual SolicitudPlaza IdSolicitudPlazaNavigation { get; set; } = null!;
        public virtual RefTemporalidad IdTemporalidadNavigation { get; set; } = null!;
        public virtual TerminoLectivo? IdTerminoLectivoNavigation { get; set; }
        public virtual RefTipoPlaza IdTipoPlazaNavigation { get; set; } = null!;
        public virtual Usuario? IdUsuarioModificacionNavigation { get; set; }
        public virtual ICollection<PlazaTransferidum> PlazaTransferida { get; set; }
        public virtual ICollection<Plaza> Plazas { get; set; }
        public virtual ICollection<SolicitudPlazaDesignacion> SolicitudPlazaDesignacions { get; set; }
    }
}
