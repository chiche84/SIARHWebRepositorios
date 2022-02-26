using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class RefTipoPeriodoEscolar
    {
        public RefTipoPeriodoEscolar()
        {
            Organizacions = new HashSet<Organizacion>();
            TerminoLectivos = new HashSet<TerminoLectivo>();
        }

        public int IdTipoPeriodoEscolar { get; set; }
        public string TipoPeriodoEscolarDesc { get; set; } = null!;
        public bool EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }

        public virtual ICollection<Organizacion> Organizacions { get; set; }
        public virtual ICollection<TerminoLectivo> TerminoLectivos { get; set; }
    }
}
