using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class Calendario
    {
        public int IdCalendario { get; set; }
        public string CalendarioDesc { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public int IdDescanso { get; set; }
        public int IdEjercicio { get; set; }
        public bool? EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }

        public virtual RefDescanso IdDescansoNavigation { get; set; } = null!;
        public virtual RefEjercicio IdEjercicioNavigation { get; set; } = null!;
    }
}
