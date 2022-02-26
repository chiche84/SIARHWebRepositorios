using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class RefTipoTablero
    {
        public RefTipoTablero()
        {
            TableroBases = new HashSet<TableroBase>();
        }

        public int IdTipoTablero { get; set; }
        public string TipoTableroDesc { get; set; } = null!;
        public bool? EsEducativo { get; set; }
        public int IdTurno { get; set; }
        public int IdGrupoNivel { get; set; }
        public bool? EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }

        public virtual RefGrupoNivel IdGrupoNivelNavigation { get; set; } = null!;
        public virtual RefTurno IdTurnoNavigation { get; set; } = null!;
        public virtual ICollection<TableroBase> TableroBases { get; set; }
    }
}
