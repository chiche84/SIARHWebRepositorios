using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    /// <summary>
    /// Paises con su respectiva nacionalidad
    /// </summary>
    public partial class RefPaisNacionalidad
    {
        public RefPaisNacionalidad()
        {
            Familia = new HashSet<Familium>();
            Personas = new HashSet<Persona>();
            Provincia = new HashSet<Provincium>();
        }

        /// <summary>
        /// Clave primaria, autoincrementable. Identificador de Pais-Nacionalidad
        /// </summary>
        public int IdPaisNacionalidad { get; set; }
        /// <summary>
        /// Nombre del país
        /// </summary>
        public string? PaisDesc { get; set; }
        /// <summary>
        /// Nombre de la nacionalidad que adopta
        /// </summary>
        public string? Nacionalidad { get; set; }
        public bool EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }

        public virtual ICollection<Familium> Familia { get; set; }
        public virtual ICollection<Persona> Personas { get; set; }
        public virtual ICollection<Provincium> Provincia { get; set; }
    }
}
