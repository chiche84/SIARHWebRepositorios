using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class PersonaTitulo
    {
        public int IdPersona { get; set; }
        public int IdTitulo { get; set; }
        public int IdEntidadOtorgante { get; set; }
        public DateTime? FechaEmision { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int IdPersonaTitulo { get; set; }
        public bool EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }

        public virtual RefEntidadOtorgante IdEntidadOtorganteNavigation { get; set; } = null!;
        public virtual Persona IdPersonaNavigation { get; set; } = null!;
        public virtual RefTitulo IdTituloNavigation { get; set; } = null!;
    }
}
