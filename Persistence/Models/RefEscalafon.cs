using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    /// <summary>
    /// Escalafon salarial de categorias. Personal docente, personal superior, etc.
    /// </summary>
    public partial class RefEscalafon
    {
        public RefEscalafon()
        {
            Presupuestos = new HashSet<Presupuesto>();
        }

        /// <summary>
        /// Clave primaria, autoincrementable. Identificador de escalafon salarial
        /// </summary>
        public int IdEscalafon { get; set; }
        /// <summary>
        /// Describe el escalafon segun presupuesto
        /// </summary>
        public string EscalafonDesc { get; set; } = null!;
        public string? Nomenclatura { get; set; }
        /// <summary>
        /// Indica si esta activa la funcion
        /// </summary>
        public bool? EstaActivo { get; set; }
        /// <summary>
        /// Fecha que deja de estar activo el escalafon
        /// </summary>
        public DateTime? FechaEliminacion { get; set; }
        public int? IdGrupoNivel { get; set; }

        public virtual RefGrupoNivel? IdGrupoNivelNavigation { get; set; }
        public virtual ICollection<Presupuesto> Presupuestos { get; set; }
    }
}
