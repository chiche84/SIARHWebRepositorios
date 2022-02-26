using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class GrupoDivisionView
    {
        public int IdGrupoDivision { get; set; }
        public int IdDivisionCabecera { get; set; }
        public int IdDivision { get; set; }
        public bool EstaActivo { get; set; }
        public int IdPlanUnidad { get; set; }
        public int IdOrganizacionTurno { get; set; }
        public string Curso { get; set; } = null!;
        public string DivisionDesc { get; set; } = null!;
        public bool EsGrupo { get; set; }
        public int IdOrganizacion { get; set; }
        public int IdHistoriaOrg { get; set; }
        public int IdTurno { get; set; }
        public string TurnoDesc { get; set; } = null!;
    }
}
