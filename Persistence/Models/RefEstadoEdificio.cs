using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    /// <summary>
    /// Estados en los que se puede encontrar un edificio. Ejemplo: Bueno, muy bueno
    /// </summary>
    public partial class RefEstadoEdificio
    {
        public RefEstadoEdificio()
        {
            Edificios = new HashSet<Edificio>();
        }

        /// <summary>
        /// Clave primaria, autoincrementable. Identificador del estado del edificio.
        /// </summary>
        public int IdEstadoEdificio { get; set; }
        /// <summary>
        /// Describe el estado del edificio, ej.: bueno, muy bueno, regular, etc.
        /// </summary>
        public string? EstadoEdificioDesc { get; set; }
        public bool? EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }

        public virtual ICollection<Edificio> Edificios { get; set; }
    }
}
