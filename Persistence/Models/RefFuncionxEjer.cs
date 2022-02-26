using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class RefFuncionxEjer
    {
        public RefFuncionxEjer()
        {
            Partida = new HashSet<Partidum>();
            Presupuestos = new HashSet<Presupuesto>();
        }

        public int IdFuncionxEjer { get; set; }
        public int IdFuncion { get; set; }
        public int IdEjercicio { get; set; }
        public string CodFuncion { get; set; } = null!;
        public bool? EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }

        public virtual RefEjercicio IdEjercicioNavigation { get; set; } = null!;
        public virtual RefFuncion IdFuncionNavigation { get; set; } = null!;
        public virtual ICollection<Partidum> Partida { get; set; }
        public virtual ICollection<Presupuesto> Presupuestos { get; set; }
    }
}
