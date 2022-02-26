using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    /// <summary>
    /// Departamentos de provincia
    /// </summary>
    public partial class Departamento
    {
        public Departamento()
        {
            Localidads = new HashSet<Localidad>();
        }

        /// <summary>
        /// Clave primaria, autoincrementable. Identificador de departamento
        /// </summary>
        public int IdDepartamento { get; set; }
        /// <summary>
        /// Nombre del departamento
        /// </summary>
        public string DepartamentoDesc { get; set; } = null!;
        /// <summary>
        /// Clave foranea. Identificador de la provincia a la que pertenece el departamento
        /// </summary>
        public int IdProvincia { get; set; }
        public bool? EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }

        public virtual Provincium IdProvinciaNavigation { get; set; } = null!;
        public virtual ICollection<Localidad> Localidads { get; set; }
    }
}
