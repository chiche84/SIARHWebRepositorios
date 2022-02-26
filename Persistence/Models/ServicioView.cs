using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class ServicioView
    {
        public int IdServicio { get; set; }
        public int IdPersona { get; set; }
        public int IdPlaza { get; set; }
        public int IdSituacionRevista { get; set; }
        public DateTime FechaDesde { get; set; }
        public DateTime? FechaHasta { get; set; }
        public int? IdTipoServicio { get; set; }
        public int? IdInstrumentoLegalAlta { get; set; }
        public int? IdExpteAlta { get; set; }
        public int? IdInstrumentoLegalBaja { get; set; }
        public int? IdExpteBaja { get; set; }
        public int IdMotivoAlta { get; set; }
        public int? IdMotivoBaja { get; set; }
        public int? IdTituloHabilitante { get; set; }
        public string? Observaciones { get; set; }
        public int? IdSolicitudDetalleDesignacion { get; set; }
        public int? IdTerminoLectivo { get; set; }
        public int? IdSubservicioOrigen { get; set; }
        public DateTime? Fechaeliminacion { get; set; }
        public bool EsEditable { get; set; }
        public int? IdSubservicioSeorigen { get; set; }
        public bool EstaFrenteAlumnoInicial { get; set; }
        public int? IdOrganizacion { get; set; }
        public int? IdHistoriaOrg { get; set; }
        public int IdCargoFuncional { get; set; }
        public int? IdPlanUnidad { get; set; }
        public int? IdPlanAsignatura { get; set; }
        public int? IdDivision { get; set; }
        public int? IdOrganizacionTurno { get; set; }
        public int? CantidadHs { get; set; }
        public int IdTemporalidad { get; set; }
        public bool BajaAutomatica { get; set; }
        public DateTime FechaHabilitacion { get; set; }
        public DateTime? FechaTermino { get; set; }
        public int IdMotivoCreacion { get; set; }
        public int? IdInstrumentoLegalCreacion { get; set; }
        public int? IdExpteCreacion { get; set; }
        public int IdSistemaEducativo { get; set; }
        public int IdRegimenLaboral { get; set; }
        public int IdRegimenSalarial { get; set; }
        public bool AdmiteSuplente { get; set; }
        public int IdFinanciamiento { get; set; }
        public int IdAfectacion { get; set; }
        public bool CobraIncentivo { get; set; }
        public string? Observacion { get; set; }
        public bool GeneraPresupuesto { get; set; }
        public int? IdOrganizacionNivelEduc { get; set; }
        public int? PlazaIdTerminoLectivo { get; set; }
        public string? Curso { get; set; }
        public string? DivisionDesc { get; set; }
        public string SituacionRevistaDesc { get; set; } = null!;
        public string TurnoDesc { get; set; } = null!;
        public string CargoSalarialDesc { get; set; } = null!;
        public string? PlanEstudioDesc { get; set; }
        public int IdPlazaHistoria { get; set; }
        public bool EstaActivo { get; set; }
        public int? IdGrupoNivel { get; set; }
        public string Nombre { get; set; } = null!;
        public string Apellido { get; set; } = null!;
        public int? MaxPlazaHistoria { get; set; }
        public string? InstrumentoLegalAltaDesc { get; set; }
        public string? InstrumentoLegalBajaDesc { get; set; }
        public string NivelEducativoDesc { get; set; } = null!;
        public string? OrganizacionDesc { get; set; }
        public bool ServicioAdmiteSuplente { get; set; }
        public string CargoFuncionalDesc { get; set; } = null!;
    }
}
