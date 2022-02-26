using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    /// <summary>
    /// Estados por los que puede pasar una solicitu de un agente (legajo)
    /// </summary>
    public partial class RefEstadosSolicitudLegajo
    {
        public RefEstadosSolicitudLegajo()
        {
            SolicitudDetalles = new HashSet<SolicitudDetalle>();
            SolicitudEstadosLegajos = new HashSet<SolicitudEstadosLegajo>();
        }

        /// <summary>
        /// Campo clave, autoincremental
        /// </summary>
        public int IdEstadoSolicitudLegajo { get; set; }
        /// <summary>
        /// Descripción del estado que puede asumir una solicitud de un agente (legajo)
        /// </summary>
        public string EstadoSolicitudDesc { get; set; } = null!;
        /// <summary>
        /// Indica si el estado se aplica al detalle de una solicitud. Por defecto es 0, es decir que aplica a la cabecera de una solicitud
        /// </summary>
        public bool AplicaDetalle { get; set; }
        /// <summary>
        /// Campo para eliminación lógica
        /// </summary>
        public bool? EstaActivo { get; set; }
        /// <summary>
        /// Fecha de eliminación lógica
        /// </summary>
        public DateTime? FechaEliminacion { get; set; }

        public virtual ICollection<SolicitudDetalle> SolicitudDetalles { get; set; }
        public virtual ICollection<SolicitudEstadosLegajo> SolicitudEstadosLegajos { get; set; }
    }
}
