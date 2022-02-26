using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class OrganizacionView
    {
        public int IdOrganizacion { get; set; }
        public int IdHistoriaOrg { get; set; }
        public bool EstaActivo { get; set; }
    }
}
