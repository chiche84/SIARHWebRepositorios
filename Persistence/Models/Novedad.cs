using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class Novedad
    {
        public int IdNovedad { get; set; }
        public int IdTableroPlaza { get; set; }
        public int IdTipoNovedad { get; set; }
        public int IdSubservicio { get; set; }
        public DateTime FechaNovedad { get; set; }
        public TimeSpan HoraDesde { get; set; }
        public TimeSpan HoraHasta { get; set; }
        public bool EstaProcesado { get; set; }
        public bool? EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }

        public virtual SubServicio IdSubservicioNavigation { get; set; } = null!;
        public virtual TableroPlaza IdTableroPlazaNavigation { get; set; } = null!;
        public virtual RefTipoNovedad IdTipoNovedadNavigation { get; set; } = null!;
    }
}
