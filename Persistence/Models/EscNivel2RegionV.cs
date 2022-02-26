using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class EscNivel2RegionV
    {
        public int IdOrganizacion { get; set; }
        public int IdHistoriaOrg { get; set; }
        public bool EsEducativo { get; set; }
        public int? Cue { get; set; }
        public string OrganizacionDesc { get; set; } = null!;
        public int? IdRegion { get; set; }
        public string RegionDesc { get; set; } = null!;
        public int IdNivelEducativo { get; set; }
        public string NivelEducativoDesc { get; set; } = null!;
        public int? IdGrupoNivel { get; set; }
        public int IdOrganizacionNivelEduc { get; set; }
        public int IdSolicitudPlaza { get; set; }
        public int? Expr1 { get; set; }
        public bool Expr2 { get; set; }
        public int IdEstadoSolicitud { get; set; }
        public string EstadoSolicitudDesc { get; set; } = null!;
        public int? IdTipoSolicitud { get; set; }
    }
}
