using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    /// <summary>
    /// Almacena el tipo de edificio, ej.: escuela, municipio, policia, hospital, etc.
    /// </summary>
    public partial class RefTipoEdificio
    {
        public RefTipoEdificio()
        {
            Edificios = new HashSet<Edificio>();
        }

        /// <summary>
        /// Clave primaria, autoincrementable. Identificador del tipo de edificio.
        /// </summary>
        public int IdTipoEdificio { get; set; }
        /// <summary>
        /// Almacena el tipo de edificio, ej.: escuela, municipio, policia, hospital, etc.
        /// </summary>
        public string TipoEdificioDesc { get; set; } = null!;
        public bool? EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }

        public virtual ICollection<Edificio> Edificios { get; set; }
    }
}
