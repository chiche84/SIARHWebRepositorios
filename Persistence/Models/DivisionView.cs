using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class DivisionView
    {
        public int IdDivision { get; set; }
        public int IdOrganizacionTurno { get; set; }
        public int IdPlanUnidad { get; set; }
        public string? Curso { get; set; }
        public string? DivisionDesc { get; set; }
        public bool EsGrupo { get; set; }
        public bool EstaActivo { get; set; }
        public int IdTurno { get; set; }
        public string TurnoDesc { get; set; } = null!;
    }
}
