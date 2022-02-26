using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    /// <summary>
    /// La organización puede ser un establecimiento educativo, organismo de gobierno, etc.
    /// </summary>
    public partial class RefTipoOrganizacion
    {
        public RefTipoOrganizacion()
        {
            Organizacions = new HashSet<Organizacion>();
        }

        /// <summary>
        /// Clave primaria, autoincrementable. Identificador del tipo de organizacion
        /// </summary>
        public int IdTipoOrganizacion { get; set; }
        /// <summary>
        /// Descriptivo almacena si la organizacion es un establecimiento educativo, organismo de gobierno
        /// </summary>
        public string? TipoOrganizacionDesc { get; set; }
        public bool? EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }

        public virtual ICollection<Organizacion> Organizacions { get; set; }
    }
}
