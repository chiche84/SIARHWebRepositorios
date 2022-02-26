using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class RespDependencium
    {
        public int IdRespDependencia { get; set; }
        public int IdDependencia { get; set; }
        public int IdPersona { get; set; }
        public DateTime? FechaDesde { get; set; }
        public DateTime? FechaHasta { get; set; }
        public bool? EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }
    }
}
