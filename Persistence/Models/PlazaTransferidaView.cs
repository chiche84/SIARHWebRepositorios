using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class PlazaTransferidaView
    {
        public int IdPlazaTransferida { get; set; }
        public int IdPlazaOrigen { get; set; }
        public int IdPlazaDestino { get; set; }
        public string OrganizacionOrigenDesc { get; set; } = null!;
        public string OrganizacionDestinoDesc { get; set; } = null!;
        public DateTime FechaDesde { get; set; }
        public DateTime? FechaHasta { get; set; }
        public bool EsTransitorio { get; set; }
        public int? NumeroSolicitud { get; set; }
        public bool EstaActivo { get; set; }
        public int? IdSolicitudPlazaDetalle { get; set; }
        public int? IdSolicitudPlaza { get; set; }
    }
}
