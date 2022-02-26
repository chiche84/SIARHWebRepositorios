using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class SolicitudDetalleLicenciaView
    {
        public int IdSolicitudLegajo { get; set; }
        public int? IdPersona { get; set; }
        public string Apellido { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public int IdMovimiento { get; set; }
        public string MovimientoDesc { get; set; } = null!;
        public DateTime FechaDesde { get; set; }
        public DateTime? FechaHasta { get; set; }
        public int? CantAños { get; set; }
        public int? CantMeses { get; set; }
        public int? CantDias { get; set; }
        public int? DiasLicencia { get; set; }
        public string NumeroArticulo { get; set; } = null!;
        public string CategoriaLicenciaDesc { get; set; } = null!;
        public int IdPlaza { get; set; }
        public int? IdPlazaHistoria { get; set; }
        public int? IdOrganizacion { get; set; }
        public int? IdHistoriaOrg { get; set; }
        public string OrganizacionDesc { get; set; } = null!;
        public int IdEjercicio { get; set; }
        public int NumeroSolicitud { get; set; }
        public int IdServicio { get; set; }
        public int IdEstadoSolicitudLegajo { get; set; }
        public string EstadoSolicitudDesc { get; set; } = null!;
        public int IdSolicitudDetalle { get; set; }
        public int? IdOrganizacionNivelEduc { get; set; }
        public int? IdEstadoSolicitudLegajoDetalle { get; set; }
        public int? IdInstrumentoLegal { get; set; }
        public int IdSituacionRevista { get; set; }
        public int? IdTipoServicio { get; set; }
        public int? IdTituloHabilitante { get; set; }
        public int? IdTerminoLectivoServ { get; set; }
    }
}
