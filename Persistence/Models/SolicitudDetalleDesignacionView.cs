using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class SolicitudDetalleDesignacionView
    {
        public int IdSolicitudLegajo { get; set; }
        public int IdTipoSolicitud { get; set; }
        public int IdEjercicio { get; set; }
        public int NumeroSolicitud { get; set; }
        public int IdHistoriaOrg { get; set; }
        public bool EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }
        public int IdOrganizacionNivelEduc { get; set; }
        public int? IdPersona { get; set; }
        public int? IdServicio { get; set; }
        public int? IdInstrumentoLegal { get; set; }
        public int? IdEstadoSolicitudLegajo { get; set; }
        public string? ObsEstado { get; set; }
        public int IdCircuitoEtapaLegajo { get; set; }
        public string? Observaciones { get; set; }
        public int IdSolicitudDetalle { get; set; }
        public DateTime FechaDesde { get; set; }
        public DateTime? FechaHasta { get; set; }
        public string OrganizacionDesc { get; set; } = null!;
        public int? Cue { get; set; }
        public string NivelEducativoDesc { get; set; } = null!;
        public int IdPlaza { get; set; }
        public int? IdTipoDocumento { get; set; }
        public int? NroDocumento { get; set; }
        public string? Cuil { get; set; }
        public string? Apellido { get; set; }
        public string? Nombre { get; set; }
        public string EstadoSolicitudDesc { get; set; } = null!;
        public int IdNivelEducativo { get; set; }
        public string? PersonaNombre { get; set; }
        public string? PersonaApellido { get; set; }
        public int? IdSexo { get; set; }
        public string CargoFuncionalDesc { get; set; } = null!;
        public string? PlanEstudioDesc { get; set; }
        public string? Curso { get; set; }
        public string? DivisionDesc { get; set; }
        public string? SituacionRevistaDesc { get; set; }
        public int? IdSituacionRevista { get; set; }
        public int IdOrganizacion { get; set; }
        public string RegimenSalarialDesc { get; set; } = null!;
        public string? TurnoDesc { get; set; }
        public int? IdTerminoLectivo { get; set; }
        public int? IdTipoServicio { get; set; }
        public int? IdTituloHabilitante { get; set; }
        public bool EstaFrenteAlumno { get; set; }
        public int? IdSolicitudDetalleSitExt { get; set; }
        public int IdMovimiento { get; set; }
        public string MovimientoDesc { get; set; } = null!;
        public string InstrumentoLegalDesc { get; set; } = null!;
        public string CircuitoEtapaLegajoDesc { get; set; } = null!;
        public int IdPlazaHistoria { get; set; }
        public bool AdmiteSuplente { get; set; }
    }
}
