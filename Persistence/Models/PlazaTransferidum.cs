using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class PlazaTransferidum
    {
        public PlazaTransferidum()
        {
            PlazaPresupuestos = new HashSet<PlazaPresupuesto>();
        }

        public int IdPlazaTransferida { get; set; }
        public int IdPlazaOrigen { get; set; }
        public int IdPlazaDestino { get; set; }
        public DateTime FechaDesde { get; set; }
        public DateTime? FechaHasta { get; set; }
        public int? IdTerminoLectivo { get; set; }
        public bool? EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }
        public bool? EsTransitorio { get; set; }
        public int? IdSolicitudPlazaDetalle { get; set; }

        public virtual Plaza IdPlazaDestinoNavigation { get; set; } = null!;
        public virtual Plaza IdPlazaOrigenNavigation { get; set; } = null!;
        public virtual SolicitudPlazaDetalle? IdSolicitudPlazaDetalleNavigation { get; set; }
        public virtual TerminoLectivo? IdTerminoLectivoNavigation { get; set; }
        public virtual ICollection<PlazaPresupuesto> PlazaPresupuestos { get; set; }
    }
}
