using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class RefTipoMovimiento
    {
        public RefTipoMovimiento()
        {
            RefMovimientos = new HashSet<RefMovimiento>();
        }

        public int IdTipoMovimiento { get; set; }
        public string TipoMovimientoDesc { get; set; } = null!;
        public bool? EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }
        /// <summary>
        /// Permite identificar si es un movimiento tipo evento, es decir no abarca un período concreto
        /// </summary>
        public bool EsHito { get; set; }

        public virtual ICollection<RefMovimiento> RefMovimientos { get; set; }
    }
}
