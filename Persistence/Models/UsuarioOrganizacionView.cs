using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class UsuarioOrganizacionView
    {
        public int IdUsuarioOrganizacion { get; set; }
        public int IdUsuario { get; set; }
        public string Usuario { get; set; } = null!;
        public int IdOrganizacion { get; set; }
        public int IdHistoriaOrg { get; set; }
        public bool EstaActivo { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime? FechaEliminacion { get; set; }
    }
}
