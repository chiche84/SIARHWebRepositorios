using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class RefTipoEfectoInstLegal
    {
        public RefTipoEfectoInstLegal()
        {
            OrganizacionxInstrumentoLegals = new HashSet<OrganizacionxInstrumentoLegal>();
        }

        public int IdTipoEfecto { get; set; }
        public string TipoEfectoDesc { get; set; } = null!;
        public bool? EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }

        public virtual ICollection<OrganizacionxInstrumentoLegal> OrganizacionxInstrumentoLegals { get; set; }
    }
}
