using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    /// <summary>
    /// Estado civil en el que puede encontrarse una persona. Ejemplo: Casado, soltero, etc.
    /// </summary>
    public partial class RefEstadoCivil
    {
        public RefEstadoCivil()
        {
            Familia = new HashSet<Familium>();
            Personas = new HashSet<Persona>();
        }

        /// <summary>
        /// Clave primaria, autoincrementable. Identificador de Estado Civil
        /// </summary>
        public int IdEstadoCivil { get; set; }
        /// <summary>
        /// Nombre de estado civil
        /// </summary>
        public string EstadoCivilDesc { get; set; } = null!;
        public bool? EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }

        public virtual ICollection<Familium> Familia { get; set; }
        public virtual ICollection<Persona> Personas { get; set; }
    }
}
