using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class SolicitudEstadosUltimoIdSolicitudEstadosView
    {
        public int IdSolicitudPlaza { get; set; }
        public int IdOrganizacion { get; set; }
        public int IdHistoriaOrg { get; set; }
        public int? IdOrganizacionNivelEduc { get; set; }
        public int? Anio { get; set; }
        public int IdEstadoSolicitud { get; set; }
        public int? IdTipoSolicitud { get; set; }
    }
}
