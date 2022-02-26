using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    /// <summary>
    /// Provincias que posee un pais
    /// </summary>
    public partial class Provincium
    {
        public Provincium()
        {
            Departamentos = new HashSet<Departamento>();
        }

        /// <summary>
        /// Clave primaria, autoincrementable. Identificador de provincia
        /// </summary>
        public int IdProvincia { get; set; }
        /// <summary>
        /// Nombre de la provincia
        /// </summary>
        public string ProvinciaDesc { get; set; } = null!;
        /// <summary>
        /// Clave foranea. Identificador del país al que pertenece la provincia
        /// </summary>
        public int IdPaisNacionalidad { get; set; }
        /// <summary>
        /// Campo para eliminación lógica. Valor 0 es igual a falso, valor 1 es igual a verdadero
        /// </summary>
        public bool? EstaActivo { get; set; }
        /// <summary>
        /// Fecha en la que deja de estar activo el registro
        /// </summary>
        public DateTime? FechaEliminacion { get; set; }

        public virtual RefPaisNacionalidad IdPaisNacionalidadNavigation { get; set; } = null!;
        public virtual ICollection<Departamento> Departamentos { get; set; }
    }
}
