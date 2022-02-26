using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class LicenciaView
    {
        public int IdSubServicio { get; set; }
        public int IdServicio { get; set; }
        public DateTime FechaDesde { get; set; }
        public DateTime? FechaHasta { get; set; }
        public int? IdInstrumentoLegal { get; set; }
        public int? IdExpteCreacion { get; set; }
        public int IdMovimiento { get; set; }
        public int? IdServicioDestino { get; set; }
        public int? IdAdicional { get; set; }
        public bool EstaFrenteAlumno { get; set; }
        public int? IdSolicitudDetalle { get; set; }
        public string MovimientoDesc { get; set; } = null!;
        public int IdTipoMovimiento { get; set; }
        public string NumeroArticulo { get; set; } = null!;
        public int? Porcentaje { get; set; }
        public string CategoriaLicenciaDesc { get; set; } = null!;
        public string OrganizacionDesc { get; set; } = null!;
        public int? IdOrganizacion { get; set; }
        public int? IdHistoriaOrg { get; set; }
        public string NivelEducativoDesc { get; set; } = null!;
        public int IdPlaza { get; set; }
        public string? InstrumentoLegalDesc { get; set; }
        public string? Observaciones { get; set; }
        public int? IdOrganizacionNivelEduc { get; set; }
        public int? IdTerminoLectivo { get; set; }
        public int? IdTipoServicio { get; set; }
        public int? IdTituloHabilitante { get; set; }
        public bool GeneraSuplente { get; set; }
        public int? IdPlazaHistoria { get; set; }
        public bool? TieneSuplente { get; set; }
        public int? IdSubServicioVinculado { get; set; }
        public bool EstaActivo { get; set; }
        public string Nombre { get; set; } = null!;
        public string Apellido { get; set; } = null!;
        public int IdPersona { get; set; }
        public string TituloHabilitanteDesc { get; set; } = null!;
        public int IdSituacionRevista { get; set; }
    }
}
