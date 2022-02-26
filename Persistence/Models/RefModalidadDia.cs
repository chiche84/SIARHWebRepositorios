using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class RefModalidadDia
    {
        public int IdModalidadDias { get; set; }
        public string ModalidadDiasDesc { get; set; } = null!;
        public bool? EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }
    }
}
