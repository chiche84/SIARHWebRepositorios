using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class SolicitudDetalleSuplenteView
    {
        public int IdSolicitudLegajo { get; set; }
        public int IdTipoSolicitud { get; set; }
        public int IdEjercicio { get; set; }
        public int NumeroSolicitud { get; set; }
        public int IdOrganizacion { get; set; }
        public int IdHistoriaOrg { get; set; }
        public int IdOrganizacionNivelEduc { get; set; }
        public int IdSolicitudDetalle { get; set; }
        public int? IdPersona { get; set; }
        public int IdMovimiento { get; set; }
        public int? IdServicio { get; set; }
        public int? IdInstrumentoLegal { get; set; }
        public int? IdExpteSolicitud { get; set; }
        public int? IdEstadoSolicitudLegajo { get; set; }
        public int IdCircuitoEtapaLegajo { get; set; }
        public int? IdSolicitudDetalleLicenciaOrigen { get; set; }
        public int? IdSubServicioOrigen { get; set; }
        public DateTime FechaDesde { get; set; }
        public DateTime? FechaHasta { get; set; }
        public int IdPlaza { get; set; }
        public int? IdSituacionRevista { get; set; }
        public int? IdTerminoLectivo { get; set; }
        public int? IdTipoServicio { get; set; }
        public int? IdTituloHabilitante { get; set; }
        public bool EstaFrenteAlumno { get; set; }
        public int IdPlazaHistoria { get; set; }
        public bool AdmiteSuplente { get; set; }
        public string MovimientoDesc { get; set; } = null!;
    }
}
