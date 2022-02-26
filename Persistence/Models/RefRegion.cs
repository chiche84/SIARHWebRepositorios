using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    /// <summary>
    /// Regiones educativas. Ejemplo: region I, region II
    /// </summary>
    public partial class RefRegion
    {
        public RefRegion()
        {
            Organizacions = new HashSet<Organizacion>();
        }

        /// <summary>
        /// Clave primaria, autoincrementable. Identificador de la region educativa
        /// </summary>
        public int IdRegion { get; set; }
        /// <summary>
        /// Descriptivo de la region educativa a la que puede pertenecer un establecimiento
        /// </summary>
        public string RegionDesc { get; set; } = null!;
        public bool? EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }

        public virtual ICollection<Organizacion> Organizacions { get; set; }
    }
}
