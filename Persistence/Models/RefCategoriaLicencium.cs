using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    /// <summary>
    /// Tipos de licecias: enfermedades cortas, maternidad, etc.
    /// </summary>
    public partial class RefCategoriaLicencium
    {
        public RefCategoriaLicencium()
        {
            Licencia = new HashSet<Licencium>();
        }

        /// <summary>
        /// Clave primaria, autoincrementable.Codigo identificador de la categoria de la licencia.
        /// </summary>
        public int IdCategoriaLicencia { get; set; }
        /// <summary>
        /// Descripcion de la categoria de la licencia, ej.: Enfermedades Cortas, Maternidad, Mayor Jerarquia, etc.
        /// </summary>
        public string CategoriaLicenciaDesc { get; set; } = null!;
        /// <summary>
        /// Identifica si el registro esta activo. (1=SI, 0=NO).
        /// </summary>
        public bool? EstaActivo { get; set; }
        /// <summary>
        /// Almacena la fecha de alta de la categoria de la licencia.
        /// </summary>
        public DateTime FechaAlta { get; set; }
        /// <summary>
        /// Almacena la fecha de baja de la categoria de la licencia.
        /// </summary>
        public DateTime? FechaEliminacion { get; set; }

        public virtual ICollection<Licencium> Licencia { get; set; }
    }
}
