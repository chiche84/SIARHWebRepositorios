using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class RefTituloHabilitante
    {
        public RefTituloHabilitante()
        {
            Servicios = new HashSet<Servicio>();
            SolicitudDetalleDesignacions = new HashSet<SolicitudDetalleDesignacion>();
            SolicitudDetalleSuplentes = new HashSet<SolicitudDetalleSuplente>();
        }

        public int IdTituloHabilitante { get; set; }
        public string TituloHabilitanteDesc { get; set; } = null!;
        public bool EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }

        public virtual ICollection<Servicio> Servicios { get; set; }
        public virtual ICollection<SolicitudDetalleDesignacion> SolicitudDetalleDesignacions { get; set; }
        public virtual ICollection<SolicitudDetalleSuplente> SolicitudDetalleSuplentes { get; set; }
    }
}
