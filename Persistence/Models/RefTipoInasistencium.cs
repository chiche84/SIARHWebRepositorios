using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class RefTipoInasistencium
    {
        public int IdTipoInasistencia { get; set; }
        public string TipoInasistenciaDesc { get; set; } = null!;
        public decimal Valor { get; set; }
        public string Mnemo { get; set; } = null!;
        public bool? EstaActivo { get; set; }
    }
}
