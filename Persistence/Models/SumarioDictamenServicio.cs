using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class SumarioDictamenServicio
    {
        public int IdDictamenServicio { get; set; }
        public int IdPersonaSumarioDictamen { get; set; }
        public int IdServicio { get; set; }
        public bool EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }

        public virtual PersonaSumarioDictaman IdPersonaSumarioDictamenNavigation { get; set; } = null!;
        public virtual Servicio IdServicioNavigation { get; set; } = null!;
    }
}
