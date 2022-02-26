using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class UdeOxEjerView
    {
        public int IdUdeO { get; set; }
        public string UdeoDesc { get; set; } = null!;
        public int IdEjercicio { get; set; }
        public string EjercicioDesc { get; set; } = null!;
        public string CodUdeO { get; set; } = null!;
        public bool EstaActivo { get; set; }
        public int IdUdeOxEjer { get; set; }
    }
}
