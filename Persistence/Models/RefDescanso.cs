using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class RefDescanso
    {
        public RefDescanso()
        {
            Calendarios = new HashSet<Calendario>();
        }

        public int IdDescanso { get; set; }
        public string DescansoDesc { get; set; } = null!;
        public DateTime FechaDesde { get; set; }
        public DateTime FechaHasta { get; set; }
        public bool EsTrasladable { get; set; }
        public int IdTipoJuridiccion { get; set; }
        public int? IdLocalidad { get; set; }
        public int IdTipoDescanso { get; set; }
        public int? IdGrupoNivel { get; set; }
        public bool EsPuente { get; set; }
        public bool? EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }

        public virtual RefGrupoNivel? IdGrupoNivelNavigation { get; set; }
        public virtual Localidad? IdLocalidadNavigation { get; set; }
        public virtual RefTipoDescanso IdTipoDescansoNavigation { get; set; } = null!;
        public virtual RefTipoJuridiccion IdTipoJuridiccionNavigation { get; set; } = null!;
        public virtual ICollection<Calendario> Calendarios { get; set; }
    }
}
