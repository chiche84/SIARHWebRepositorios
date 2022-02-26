using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    /// <summary>
    /// Registro de feriados o días no laborables
    /// </summary>
    public partial class RefCalendarioFeriado
    {
        /// <summary>
        /// Primary key
        /// </summary>
        public int IdCalendarioFeriado { get; set; }
        public DateTime FechaFeriado { get; set; }
        public string CalendarioFeriadoDesc { get; set; } = null!;
        public bool? EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }
    }
}
