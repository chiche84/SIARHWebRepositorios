using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class RefEstadoPlaza
    {
        public RefEstadoPlaza()
        {
            Plazas = new HashSet<Plaza>();
            RefSubEstadoPlazas = new HashSet<RefSubEstadoPlaza>();
        }

        public byte IdEstadoPlaza { get; set; }
        public string? EstadoPlazaDesc { get; set; }
        public bool EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }

        public virtual ICollection<Plaza> Plazas { get; set; }
        public virtual ICollection<RefSubEstadoPlaza> RefSubEstadoPlazas { get; set; }
    }
}
