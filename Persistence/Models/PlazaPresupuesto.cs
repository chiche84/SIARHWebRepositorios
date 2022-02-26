using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class PlazaPresupuesto
    {
        public int IdPlazaPresupuesto { get; set; }
        public int IdPlaza { get; set; }
        public int IdPresupuesto { get; set; }
        public int? IdPartida { get; set; }
        public bool? EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }
        public int? IdPartidaSuplente { get; set; }
        public DateTime FechaHabilitacion { get; set; }
        public DateTime FechaTermino { get; set; }
        public int IdPlazaHistoria { get; set; }
        public int? IdPlazaTransferida { get; set; }
        public int? IdAfectacion { get; set; }

        public virtual RefAfectacion? IdAfectacionNavigation { get; set; }
        public virtual Partidum? IdPartidaNavigation { get; set; }
        public virtual PlazaHistorium IdPlaza1 { get; set; } = null!;
        public virtual Plaza IdPlazaNavigation { get; set; } = null!;
        public virtual PlazaTransferidum? IdPlazaTransferidaNavigation { get; set; }
        public virtual Presupuesto IdPresupuestoNavigation { get; set; } = null!;
    }
}
