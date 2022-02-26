using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    /// <summary>
    /// Tipo de educacion. Ejemplo: especial, comun
    /// </summary>
    public partial class RefTipoEducacion
    {
        public RefTipoEducacion()
        {
            Organizacions = new HashSet<Organizacion>();
        }

        /// <summary>
        /// Clave primaria, autoincrementable. Identificador del tipo de educacion
        /// </summary>
        public int IdTipoEducacion { get; set; }
        /// <summary>
        /// Descriptivo del tipo de educacion: Especial; Comun
        /// </summary>
        public string TipoEducacionDesc { get; set; } = null!;
        public bool? EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }

        public virtual ICollection<Organizacion> Organizacions { get; set; }
    }
}
