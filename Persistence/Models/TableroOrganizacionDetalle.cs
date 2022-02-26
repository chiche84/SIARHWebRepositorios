using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class TableroOrganizacionDetalle
    {
        public TableroOrganizacionDetalle()
        {
            TableroPlazas = new HashSet<TableroPlaza>();
        }

        public int IdTableroOrganizacionDetalle { get; set; }
        public int IdTableroOrganizacion { get; set; }
        public int IdDiaSemana { get; set; }
        public TimeSpan HoraDesde { get; set; }
        public TimeSpan HoraHasta { get; set; }
        public int? NroModulo { get; set; }
        public bool? EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }

        public virtual RefDiaSemana IdDiaSemanaNavigation { get; set; } = null!;
        public virtual TableroOrganizacion IdTableroOrganizacionNavigation { get; set; } = null!;
        public virtual ICollection<TableroPlaza> TableroPlazas { get; set; }
    }
}
