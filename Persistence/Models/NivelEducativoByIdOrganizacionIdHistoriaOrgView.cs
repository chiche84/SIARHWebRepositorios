using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class NivelEducativoByIdOrganizacionIdHistoriaOrgView
    {
        public int IdOrganizacionNivelEduc { get; set; }
        public int IdOrganizacion { get; set; }
        public int IdHistoriaOrg { get; set; }
        public int IdNivelEducativo { get; set; }
        public int? IdGrupoNivel { get; set; }
        public string? IdNeidGn { get; set; }
        public string NivelEducativoDesc { get; set; } = null!;
    }
}
