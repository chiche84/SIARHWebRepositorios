using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class TableroPlaza
    {
        public TableroPlaza()
        {
            Novedads = new HashSet<Novedad>();
        }

        public int IdTableroPlaza { get; set; }
        public int IdTableroOrganizacionDetalle { get; set; }
        public int IdPlaza { get; set; }
        public DateTime? FechaDesde { get; set; }
        public DateTime? FechaHasta { get; set; }
        public bool? EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }

        public virtual Plaza IdPlazaNavigation { get; set; } = null!;
        public virtual TableroOrganizacionDetalle IdTableroOrganizacionDetalleNavigation { get; set; } = null!;
        public virtual ICollection<Novedad> Novedads { get; set; }
    }
}
