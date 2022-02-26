using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class RefTipoNovedadLua
    {
        public int IdTipoNovedad { get; set; }
        public string TipoNovedadDesc { get; set; } = null!;
        public string? Estado { get; set; }
        public bool EstaActivo { get; set; }
    }
}
