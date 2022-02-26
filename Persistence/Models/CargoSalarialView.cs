using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class CargoSalarialView
    {
        public int IdCargoSalarial { get; set; }
        public string CargoSalarialDesc { get; set; } = null!;
        public int IdJornada { get; set; }
        public bool EstaActivo { get; set; }
        public int IdUdeO { get; set; }
        public string UdeoDesc { get; set; } = null!;
        public string EjercicioUdeo { get; set; } = null!;
        public int IdEscalafon { get; set; }
        public string EscalafonDesc { get; set; } = null!;
        public string? EjercicioFinalidad { get; set; }
        public int? IdFinalidad { get; set; }
        public string? FinalidadDesc { get; set; }
        public int? IdFuncion { get; set; }
        public string? FuncionDesc { get; set; }
        public string? EjercicioFuncion { get; set; }
    }
}
