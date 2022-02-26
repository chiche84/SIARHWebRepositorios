using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class AplicacionUsuario
    {
        public int IdAplicacionUsuario { get; set; }
        public int IdAplicacion { get; set; }
        public int IdUsuario { get; set; }
        public bool EstaActivo { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime? FechaEliminacion { get; set; }

        public virtual RefAplicacion IdAplicacionNavigation { get; set; } = null!;
        public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
    }
}
