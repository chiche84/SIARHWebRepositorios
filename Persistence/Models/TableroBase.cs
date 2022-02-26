using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class TableroBase
    {
        public int IdTableroBase { get; set; }
        public int IdTipoTablero { get; set; }
        public int IdDiaSemana { get; set; }
        public TimeSpan HoraDesde { get; set; }
        public TimeSpan HoraHasta { get; set; }
        public int? NroModulo { get; set; }
        public bool? EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }

        public virtual RefDiaSemana IdDiaSemanaNavigation { get; set; } = null!;
        public virtual RefTipoTablero IdTipoTableroNavigation { get; set; } = null!;
    }
}
