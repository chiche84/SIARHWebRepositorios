using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    /// <summary>
    /// Niveles de enseñanza: Ejemplo: primario, secundario, etc,
    /// </summary>
    public partial class RefNivelEducativo
    {
        public RefNivelEducativo()
        {
            Familia = new HashSet<Familium>();
            OrganizacionNivelEducativos = new HashSet<OrganizacionNivelEducativo>();
            Personas = new HashSet<Persona>();
            PlanEstudios = new HashSet<PlanEstudio>();
            RefTitulos = new HashSet<RefTitulo>();
        }

        /// <summary>
        /// Clave primaria, autoincrementable. Identificador de nivel de escolaridad
        /// </summary>
        public int IdNivelEducativo { get; set; }
        /// <summary>
        /// Nombre del nivel de escolaridad: Ejemplo: primario, secundario, terciario, universitario
        /// </summary>
        public string NivelEducativoDesc { get; set; } = null!;
        /// <summary>
        /// Campo para eliminación lógica
        /// </summary>
        public bool? EstaActivo { get; set; }
        /// <summary>
        /// Fecha  en la que deja de estar activo el nivel de escolaridad
        /// </summary>
        public DateTime? FechaEliminacion { get; set; }
        /// <summary>
        /// Puede tomar los valores 1,2,3, (Primario Secundario y Terciario) Campos que se utiliza para las Solicitudes
        /// </summary>
        public int? IdGrupoNivel { get; set; }

        public virtual ICollection<Familium> Familia { get; set; }
        public virtual ICollection<OrganizacionNivelEducativo> OrganizacionNivelEducativos { get; set; }
        public virtual ICollection<Persona> Personas { get; set; }
        public virtual ICollection<PlanEstudio> PlanEstudios { get; set; }
        public virtual ICollection<RefTitulo> RefTitulos { get; set; }
    }
}
