using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    /// <summary>
    /// Localidades por departamento
    /// </summary>
    public partial class Localidad
    {
        public Localidad()
        {
            Edificios = new HashSet<Edificio>();
            PersonaIdLocalidadNacimientoNavigations = new HashSet<Persona>();
            PersonaIdLocalidadNavigations = new HashSet<Persona>();
            RefDescansos = new HashSet<RefDescanso>();
        }

        /// <summary>
        /// Clave primaria, autoincrementable. Identificador de la localidad
        /// </summary>
        public int IdLocalidad { get; set; }
        /// <summary>
        /// Nombre de la localidad
        /// </summary>
        public string LocalidadDesc { get; set; } = null!;
        /// <summary>
        /// Clave foranea. Identificador del departamento al que pertenece la localidad
        /// </summary>
        public int IdDepartamento { get; set; }
        /// <summary>
        /// Codigo postal de la localidad
        /// </summary>
        public int? CodigoPostal { get; set; }
        public bool? EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }

        public virtual Departamento IdDepartamentoNavigation { get; set; } = null!;
        public virtual ICollection<Edificio> Edificios { get; set; }
        public virtual ICollection<Persona> PersonaIdLocalidadNacimientoNavigations { get; set; }
        public virtual ICollection<Persona> PersonaIdLocalidadNavigations { get; set; }
        public virtual ICollection<RefDescanso> RefDescansos { get; set; }
    }
}
