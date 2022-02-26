using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class PlanEspacioCurricular
    {
        public int IdPlanEspacio { get; set; }
        public int IdPlanEstudio { get; set; }
        public int IdEspacioCurricular { get; set; }
        public int? Anio { get; set; }
        public int? CargaHoraria { get; set; }
        public bool? EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }
        public string? PlanEspacioDesc { get; set; }
        public int? IdRegimen { get; set; }
        public string EspacioCurricularDesc { get; set; } = null!;
        public string? RegimenDesc { get; set; }
    }
}
