using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class SubServicioView
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
        public int? IdTerminoLectivo { get; set; }
        public string? InstrumentoLegalDesc { get; set; }
        public string TipoMovimientoDesc { get; set; } = null!;
        public int IdTipoMovimiento { get; set; }
        public bool EstaActivo { get; set; }
        public string MovimientoDesc { get; set; } = null!;
        public int IdPlaza { get; set; }
        public bool GeneraSuplente { get; set; }
        public bool EsHito { get; set; }
        public bool? TieneSuplente { get; set; }
        public int? IdSubServicioVinculado { get; set; }
    }
}
