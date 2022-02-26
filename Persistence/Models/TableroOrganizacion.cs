using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class TableroOrganizacion
    {
        public TableroOrganizacion()
        {
            TableroOrganizacionDetalles = new HashSet<TableroOrganizacionDetalle>();
        }

        public int IdTableroOrganizacion { get; set; }
        public int IdOrganizacionNivelEducativo { get; set; }
        public int IdOrganizacionTurno { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int IdEjercicio { get; set; }
        public bool? EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }

        public virtual RefEjercicio IdEjercicioNavigation { get; set; } = null!;
        public virtual OrganizacionNivelEducativo IdOrganizacionNivelEducativoNavigation { get; set; } = null!;
        public virtual OrganizacionTurno IdOrganizacionTurnoNavigation { get; set; } = null!;
        public virtual ICollection<TableroOrganizacionDetalle> TableroOrganizacionDetalles { get; set; }
    }
}
