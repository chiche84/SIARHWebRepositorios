using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class RefFinalidadxEjer
    {
        public RefFinalidadxEjer()
        {
            Partida = new HashSet<Partidum>();
            Presupuestos = new HashSet<Presupuesto>();
        }

        public int IdFinalidadxEjer { get; set; }
        public int IdFinalidad { get; set; }
        public int IdEjercicio { get; set; }
        public string CodFinalidad { get; set; } = null!;
        public bool? EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }

        public virtual RefEjercicio IdEjercicioNavigation { get; set; } = null!;
        public virtual RefFinalidad IdFinalidadNavigation { get; set; } = null!;
        public virtual ICollection<Partidum> Partida { get; set; }
        public virtual ICollection<Presupuesto> Presupuestos { get; set; }
    }
}
