using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    /// <summary>
    /// Tipos de tenencia. Un edificio puede ser propio, alquilado, etc. 
    /// </summary>
    public partial class RefTipoTenencium
    {
        public RefTipoTenencium()
        {
            Edificios = new HashSet<Edificio>();
        }

        /// <summary>
        /// Clave primaria, autoincrementable. Identificador del tipo de tenencia del edificio.
        /// </summary>
        public int IdTipoTenencia { get; set; }
        /// <summary>
        /// Describe el tipo de tenencia de un edificio, ej.: propio, alquilado, cedido, etc.
        /// </summary>
        public string TipoTenenciaDesc { get; set; } = null!;
        public bool? EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }

        public virtual ICollection<Edificio> Edificios { get; set; }
    }
}
