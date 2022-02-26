using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    /// <summary>
    /// Categorias de establecimientos educativos. Primera categoria, segunda categoria, etc. Esta categoria se da según la cantidad de alumnos del establecimiento
    /// </summary>
    public partial class RefCategoriaOrganizacion
    {
        public RefCategoriaOrganizacion()
        {
            Organizacions = new HashSet<Organizacion>();
        }

        /// <summary>
        /// Clave primaria, autoincrementable. 
        /// </summary>
        public int IdCategoriaOrganizacion { get; set; }
        /// <summary>
        /// Categoria de la organización. Ejemplo: Primera, segunda
        /// </summary>
        public string CategoriaOrganizacionDesc { get; set; } = null!;
        public bool? EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }

        public virtual ICollection<Organizacion> Organizacions { get; set; }
    }
}
