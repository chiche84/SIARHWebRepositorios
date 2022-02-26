using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class PerSumarioOrganizacion
    {
        public int IdPerSumarioOrganizacion { get; set; }
        public int IdPersonaSumario { get; set; }
        public int IdOrganizacion { get; set; }
        public int IdHistoriaOrg { get; set; }
        public bool? EstaActivo { get; set; }
        public DateTime? FechaEliminaicon { get; set; }

        public virtual Organizacion Id { get; set; } = null!;
        public virtual PersonaSumario IdPersonaSumarioNavigation { get; set; } = null!;
    }
}
