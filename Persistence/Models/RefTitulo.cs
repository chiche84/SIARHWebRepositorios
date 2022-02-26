using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class RefTitulo
    {
        public RefTitulo()
        {
            PersonaTitulos = new HashSet<PersonaTitulo>();
        }

        public int IdTitulo { get; set; }
        public string TituloDesc { get; set; } = null!;
        public int IdNivelEducativo { get; set; }
        public int? CantidadAnios { get; set; }
        public bool EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }

        public virtual RefNivelEducativo IdNivelEducativoNavigation { get; set; } = null!;
        public virtual ICollection<PersonaTitulo> PersonaTitulos { get; set; }
    }
}
