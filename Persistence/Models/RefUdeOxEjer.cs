using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class RefUdeOxEjer
    {
        public RefUdeOxEjer()
        {
            Partida = new HashSet<Partidum>();
            Presupuestos = new HashSet<Presupuesto>();
        }

        public int IdUdeOxEjer { get; set; }
        public int IdUdeO { get; set; }
        public int IdEjercicio { get; set; }
        public string CodUdeO { get; set; } = null!;
        public bool? EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }

        public virtual RefEjercicio IdEjercicioNavigation { get; set; } = null!;
        public virtual RefUdeO IdUdeONavigation { get; set; } = null!;
        public virtual ICollection<Partidum> Partida { get; set; }
        public virtual ICollection<Presupuesto> Presupuestos { get; set; }
    }
}
