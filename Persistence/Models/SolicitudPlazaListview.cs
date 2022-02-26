using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class SolicitudPlazaListview
    {
        public int IdSolicitudPlaza { get; set; }
        public int IdEstadoSolicitud { get; set; }
        public string EstadoSolicitudDesc { get; set; } = null!;
        public int IdCircuitoSol { get; set; }
        public string CircuitoSolDesc { get; set; } = null!;
        public int IdOrganizacion { get; set; }
        public int IdHistoriaOrg { get; set; }
        public int? IdOrganizacionNivelEduc { get; set; }
        public string? NivelEducativoDesc { get; set; }
        public int? IdEjercicio { get; set; }
        public int? NumeroSolicitud { get; set; }
        public int? IdGrupoNivel { get; set; }
        public string? OrganizacionDesc { get; set; }
        public string TipoSolicitudDesc { get; set; } = null!;
        public int? IdTipoSolicitud { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int? IdNivelEducativo { get; set; }
        public string? EjercicioDesc { get; set; }
        public int? Anio { get; set; }
    }
}
