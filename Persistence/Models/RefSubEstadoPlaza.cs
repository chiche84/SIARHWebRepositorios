using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class RefSubEstadoPlaza
    {
        public RefSubEstadoPlaza()
        {
            Plazas = new HashSet<Plaza>();
        }

        public byte IdSubEstadoPlaza { get; set; }
        /// <summary>
        /// Clave foranea, Estado Plaza. Ejemplo: activo
        /// </summary>
        public byte IdEstadoPlaza { get; set; }
        /// <summary>
        /// Descripción del subestado. Ejemplo para estado activo, subestado vacante, libre, ocupada
        /// </summary>
        public string Subestado { get; set; } = null!;
        public bool? EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }

        public virtual RefEstadoPlaza IdEstadoPlazaNavigation { get; set; } = null!;
        public virtual ICollection<Plaza> Plazas { get; set; }
    }
}
