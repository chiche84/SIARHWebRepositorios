using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class RefDiaDescansoAnual
    {
        /// <summary>
        /// Primary key
        /// </summary>
        public int IdDiaDescansoAnual { get; set; }
        /// <summary>
        /// Describe el comienzo del intervalo en años para los dias de descanso anual
        /// </summary>
        public int AnioDesde { get; set; }
        /// <summary>
        /// Describe el fin del intervalo en años para los dias de descanso anual
        /// </summary>
        public int AnioHasta { get; set; }
        /// <summary>
        /// Dias de descanso que corresponde segun el intervalo de años (desde-hasta)
        /// </summary>
        public int DiaDescanso { get; set; }
        public string? DiaDescansoAnualDesc { get; set; }
        public bool? EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }
    }
}
