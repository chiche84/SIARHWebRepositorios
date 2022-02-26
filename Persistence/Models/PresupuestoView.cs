using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class PresupuestoView
    {
        public int IdPresupuesto { get; set; }
        public int IdCargoSalarial { get; set; }
        public int IdAdicional { get; set; }
        public int CantPresupuestada { get; set; }
        public int IdUdeOxEjer { get; set; }
        public bool EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }
        public int? CantDisponible { get; set; }
        public string CargoSalarialDesc { get; set; } = null!;
        public string AdicionalDesc { get; set; } = null!;
        public int? Porcentaje { get; set; }
        public string EjercicioDesc { get; set; } = null!;
        public string CodUdeO { get; set; } = null!;
        public string UdeoDesc { get; set; } = null!;
        public int IdEjercicio { get; set; }
        public string EscalafonDesc { get; set; } = null!;
        public int IdEscalafon { get; set; }
        public int? IdFinalidadxEjer { get; set; }
        public int? IdFuncionxEjer { get; set; }
        public string? CodFinalidad { get; set; }
        public string? FinalidadDesc { get; set; }
        public string? CodFuncion { get; set; }
        public string? FuncionDesc { get; set; }
    }
}
