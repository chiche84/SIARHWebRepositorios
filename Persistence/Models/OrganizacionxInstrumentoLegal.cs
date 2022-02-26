using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class OrganizacionxInstrumentoLegal
    {
        public int IdOrganizacionxInsLegal { get; set; }
        public int IdOrganizacion { get; set; }
        public int IdHistoriaOrg { get; set; }
        public int IdInstrumentoLegal { get; set; }
        public int IdTipoEfecto { get; set; }
        public bool? EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }

        public virtual Organizacion Id { get; set; } = null!;
        public virtual InstrumentoLegal IdInstrumentoLegalNavigation { get; set; } = null!;
        public virtual RefTipoEfectoInstLegal IdTipoEfectoNavigation { get; set; } = null!;
    }
}
