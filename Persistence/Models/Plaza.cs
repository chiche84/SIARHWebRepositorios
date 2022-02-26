using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    /// <summary>
    /// Plaza o cargo
    /// </summary>
    public partial class Plaza
    {
        public Plaza()
        {
            PaquetePlazas = new HashSet<PaquetePlaza>();
            PlazaHistoria = new HashSet<PlazaHistorium>();
            PlazaPresupuestos = new HashSet<PlazaPresupuesto>();
            PlazaTransferidumIdPlazaDestinoNavigations = new HashSet<PlazaTransferidum>();
            PlazaTransferidumIdPlazaOrigenNavigations = new HashSet<PlazaTransferidum>();
            SolicitudDetalleSitExts = new HashSet<SolicitudDetalleSitExt>();
            SolicitudDetalleSuplentes = new HashSet<SolicitudDetalleSuplente>();
            TableroPlazas = new HashSet<TableroPlaza>();
        }

        /// <summary>
        /// Es el numero de CUPOF, representa de forma univoca a la plaza
        /// </summary>
        public int IdPlaza { get; set; }
        public int? IdOrganizacion { get; set; }
        public int? IdHistoriaOrg { get; set; }
        /// <summary>
        /// Clave foranea, identifica la funcion a desempeñar en la plaza (tentativa o por defecto).
        /// </summary>
        public int IdCargoFuncional { get; set; }
        public int? IdPlanAsignatura { get; set; }
        /// <summary>
        /// Clave foranea, almacena la division actual de la plaza.
        /// </summary>
        public int? IdDivision { get; set; }
        public int? IdOrganizacionTurno { get; set; }
        /// <summary>
        /// Almacena la cantidad de horas de la plaza.
        /// </summary>
        public int? CantidadHs { get; set; }
        public int IdTemporalidad { get; set; }
        public bool BajaAutomatica { get; set; }
        /// <summary>
        /// Fecha de alta de la habilitación presupuestaria de la plaza.
        /// </summary>
        public DateTime FechaHabilitacion { get; set; }
        /// <summary>
        /// Fecha de baja de la habilitación presupuestaria de la plaza.
        /// </summary>
        public DateTime? FechaTermino { get; set; }
        public DateTime FechaCreacion { get; set; }
        /// <summary>
        /// Clave foranea, permite indicar el motivo de creacion de la plaza, POF, NO POF.
        /// </summary>
        public int IdMotivoCreacion { get; set; }
        /// <summary>
        /// Clave foranea, guarda el inst.legal de creacion de la plaza.
        /// </summary>
        public int? IdInstrumentoLegalCreacion { get; set; }
        /// <summary>
        /// Clave foranea, guarda el expediente de creacion de la plaza.
        /// </summary>
        public int? IdExpteCreacion { get; set; }
        /// <summary>
        /// Clave foranea, guarda el instrumento legal de baja de la plaza.
        /// </summary>
        public int? IdInstrumentoLegalBaja { get; set; }
        /// <summary>
        /// Motivo de baja. Vinculado con RefMovimiento (tipo motivo: baja)
        /// </summary>
        public int? IdMotivoBaja { get; set; }
        /// <summary>
        /// Clave foranea, indica si pertenece o no al sistema educativo (ej: cargo por Planes Sociales).
        /// </summary>
        public int IdSistemaEducativo { get; set; }
        /// <summary>
        /// Clave foranea, indica si es docente, no docente.
        /// </summary>
        public int IdRegimenLaboral { get; set; }
        /// <summary>
        /// Clave foranea, identifica si la plaza esta conformada por Horas o Cargos.
        /// </summary>
        public int IdRegimenSalarial { get; set; }
        /// <summary>
        /// Clave foranea, identifica el financiamiento prespuestario de la plaza.
        /// </summary>
        public int IdFinanciamiento { get; set; }
        public int IdEducacionDiferencial { get; set; }
        /// <summary>
        /// Clave foranea, identifica si la plaza permite suplentes.
        /// </summary>
        public bool? AdmiteSuplente { get; set; }
        public bool CobraIncentivo { get; set; }
        /// <summary>
        /// Clave foranea, identificador de afectación presupuestaria, Ej: intra presupuestario, extrapresupuestario
        /// </summary>
        public int IdAfectacion { get; set; }
        /// <summary>
        /// Observaciones de la plaza.
        /// </summary>
        public string? Observacion { get; set; }
        public bool? EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }
        /// <summary>
        /// Clave foranea. Si la plaza pertenece a un paquete de plazas, identifica a la plaza cabecera. ACTUALMENTE NO ESTÁ EN USO
        /// </summary>
        public int? IdPaquete { get; set; }
        /// <summary>
        /// Indica si la plaza es la cabecera de un paquete de plazas. (0=No, 1=Si) ACTUALMENTE NO ESTÁ EN USO
        /// </summary>
        public bool? EsCabeceraDePaquete { get; set; }
        /// <summary>
        /// Vincula la solicitud y detalle de la solicitud por la cuál se generó la plaza
        /// </summary>
        public int? IdSolicitudPlazaDetalle { get; set; }
        /// <summary>
        /// Indica si la plaza genera gastos. Para un traslado transitorio, este campo podría ser falso.
        /// </summary>
        public bool GeneraPresupuesto { get; set; }
        public byte IdEstadoPlaza { get; set; }
        /// <summary>
        /// Nivel educativo para el que se crea la plaza
        /// </summary>
        public int? IdOrganizacionNivelEduc { get; set; }
        public int? IdTerminoLectivo { get; set; }
        public byte? IdSubEstadoPlaza { get; set; }

        public virtual Organizacion? Id { get; set; }
        public virtual RefAfectacion IdAfectacionNavigation { get; set; } = null!;
        public virtual CargoFuncional IdCargoFuncionalNavigation { get; set; } = null!;
        public virtual Division? IdDivisionNavigation { get; set; }
        public virtual RefEducacionDiferencial IdEducacionDiferencialNavigation { get; set; } = null!;
        public virtual RefEstadoPlaza IdEstadoPlazaNavigation { get; set; } = null!;
        public virtual RefFinanciamiento IdFinanciamientoNavigation { get; set; } = null!;
        public virtual InstrumentoLegal? IdInstrumentoLegalBajaNavigation { get; set; }
        public virtual InstrumentoLegal? IdInstrumentoLegalCreacionNavigation { get; set; }
        public virtual RefMotivoBaja? IdMotivoBajaNavigation { get; set; }
        public virtual RefMotivoCreacion IdMotivoCreacionNavigation { get; set; } = null!;
        public virtual OrganizacionNivelEducativo? IdOrganizacionNivelEducNavigation { get; set; }
        public virtual OrganizacionTurno? IdOrganizacionTurnoNavigation { get; set; }
        public virtual PaquetePlaza? IdPaqueteNavigation { get; set; }
        public virtual PlanAsignatura? IdPlanAsignaturaNavigation { get; set; }
        public virtual RefRegimenLaboral IdRegimenLaboralNavigation { get; set; } = null!;
        public virtual RefRegimenSalarial IdRegimenSalarialNavigation { get; set; } = null!;
        public virtual RefSistemaEducativo IdSistemaEducativoNavigation { get; set; } = null!;
        public virtual SolicitudPlazaDetalle? IdSolicitudPlazaDetalleNavigation { get; set; }
        public virtual RefSubEstadoPlaza? IdSubEstadoPlazaNavigation { get; set; }
        public virtual RefTemporalidad IdTemporalidadNavigation { get; set; } = null!;
        public virtual TerminoLectivo? IdTerminoLectivoNavigation { get; set; }
        public virtual ICollection<PaquetePlaza> PaquetePlazas { get; set; }
        public virtual ICollection<PlazaHistorium> PlazaHistoria { get; set; }
        public virtual ICollection<PlazaPresupuesto> PlazaPresupuestos { get; set; }
        public virtual ICollection<PlazaTransferidum> PlazaTransferidumIdPlazaDestinoNavigations { get; set; }
        public virtual ICollection<PlazaTransferidum> PlazaTransferidumIdPlazaOrigenNavigations { get; set; }
        public virtual ICollection<SolicitudDetalleSitExt> SolicitudDetalleSitExts { get; set; }
        public virtual ICollection<SolicitudDetalleSuplente> SolicitudDetalleSuplentes { get; set; }
        public virtual ICollection<TableroPlaza> TableroPlazas { get; set; }
    }
}
