using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class RefEntidadOtorgante
    {
        public RefEntidadOtorgante()
        {
            PersonaTitulos = new HashSet<PersonaTitulo>();
        }

        public int IdEntidadOtorgante { get; set; }
        public string EntidadOtorganteDesc { get; set; } = null!;
        public bool EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }

        public virtual ICollection<PersonaTitulo> PersonaTitulos { get; set; }
    }
}
