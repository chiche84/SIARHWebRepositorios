using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class PermutaServicio
    {
        public int IdPermutaServicio { get; set; }
        public int IdPermuta { get; set; }
        public int IdServicioOrigen { get; set; }
        public int? IdServicioDestino { get; set; }
        public bool? EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }

        public virtual Permutum IdPermutaNavigation { get; set; } = null!;
        public virtual Servicio? IdServicioDestinoNavigation { get; set; }
        public virtual Servicio IdServicioOrigenNavigation { get; set; } = null!;
    }
}
