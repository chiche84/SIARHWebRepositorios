using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class RefGrupoNivel
    {
        public RefGrupoNivel()
        {
            CircuitoSolicitudLegajos = new HashSet<CircuitoSolicitudLegajo>();
            Licencia = new HashSet<Licencium>();
            RefDescansos = new HashSet<RefDescanso>();
            RefEscalafons = new HashSet<RefEscalafon>();
            RefTipoTableros = new HashSet<RefTipoTablero>();
            TerminoLectivos = new HashSet<TerminoLectivo>();
        }

        public int IdGrupoNivel { get; set; }
        public string GrupoDesc { get; set; } = null!;
        public bool? EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }

        public virtual ICollection<CircuitoSolicitudLegajo> CircuitoSolicitudLegajos { get; set; }
        public virtual ICollection<Licencium> Licencia { get; set; }
        public virtual ICollection<RefDescanso> RefDescansos { get; set; }
        public virtual ICollection<RefEscalafon> RefEscalafons { get; set; }
        public virtual ICollection<RefTipoTablero> RefTipoTableros { get; set; }
        public virtual ICollection<TerminoLectivo> TerminoLectivos { get; set; }
    }
}
