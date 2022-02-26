using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class NodosOrg
    {
        public int IdNodo { get; set; }
        public int IdOrganizacion { get; set; }
        public int IdHistoriaOrg { get; set; }
        public int? IdOrganizacionPadre { get; set; }
        public int? IdHistoriaOrgPadre { get; set; }
        public bool TieneHijo { get; set; }

        public virtual Organizacion Id { get; set; } = null!;
        public virtual Organizacion? IdNavigation { get; set; }
    }
}
