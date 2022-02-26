using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    /// <summary>
    /// Unidadades temporales. Ejemplo: dias corridos, dias habiles.
    /// </summary>
    public partial class RefUnidadTemporal
    {
        public RefUnidadTemporal()
        {
            Licencia = new HashSet<Licencium>();
            PersonaSumarioDictamen = new HashSet<PersonaSumarioDictaman>();
        }

        /// <summary>
        /// Clave primaria, autoincrementable.Codigo identificador de la unidad temporal.
        /// </summary>
        public int IdUnidadTemporal { get; set; }
        /// <summary>
        /// Descripcion de la unidad temporal, ej.: dias corridos, dias habiles.
        /// </summary>
        public string UnidadTemporalDesc { get; set; } = null!;
        public bool? EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }

        public virtual ICollection<Licencium> Licencia { get; set; }
        public virtual ICollection<PersonaSumarioDictaman> PersonaSumarioDictamen { get; set; }
    }
}
