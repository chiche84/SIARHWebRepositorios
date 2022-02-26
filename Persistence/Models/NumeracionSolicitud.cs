using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class NumeracionSolicitud
    {
        public int IdNumeracion { get; set; }
        public int IdEjercicio { get; set; }
        public int NumeracionLicencia { get; set; }
        public int NumeracionDesignacion { get; set; }
        public int NumeracionSituacionExtraordinaria { get; set; }
        public int NumeracionSolicitudPlaza { get; set; }
        public bool? EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }
        public int NumeracionSolicitudTurno { get; set; }

        public virtual RefEjercicio IdEjercicioNavigation { get; set; } = null!;
    }
}
