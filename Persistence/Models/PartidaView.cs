using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class PartidaView
    {
        public int IdPartida { get; set; }
        public string Partida { get; set; } = null!;
        public decimal? ImportePartida { get; set; }
        public int IdEjercicio { get; set; }
        public string? Codigo { get; set; }
        public int IdUdeOxEjer { get; set; }
        public int IdFinalidadxEjer { get; set; }
        public int IdFuncionxEjer { get; set; }
        public int IdCuenta { get; set; }
    }
}
