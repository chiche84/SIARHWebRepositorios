using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    /// <summary>
    /// Estado en los que se puede encontrar una solicitud de habilitacion de plaza: borrador, pendiente; autorizado; habilitado
    /// </summary>
    public partial class RefEstadoSolicitud
    {
        public RefEstadoSolicitud()
        {
            ReqSolicitudPrimaria = new HashSet<ReqSolicitudPrimarium>();
            SolicitudEstados = new HashSet<SolicitudEstado>();
            SolicitudEstadosTurnos = new HashSet<SolicitudEstadosTurno>();
            SolicitudPlazaDetalles = new HashSet<SolicitudPlazaDetalle>();
        }

        /// <summary>
        /// Clave primaria, autoincremental. Identiifcador de estado de solicitud
        /// </summary>
        public int IdEstadoSolicitud { get; set; }
        /// <summary>
        /// Estado de solicitud: pendiente, autorizada, etc.
        /// </summary>
        public string EstadoSolicitudDesc { get; set; } = null!;
        /// <summary>
        /// Campo para eliminacion logica
        /// </summary>
        public bool? EstaActivo { get; set; }
        /// <summary>
        /// Fecha en la que deja de estar activo el estado de la solicitud
        /// </summary>
        public DateTime? FechaEliminacion { get; set; }

        public virtual ICollection<ReqSolicitudPrimarium> ReqSolicitudPrimaria { get; set; }
        public virtual ICollection<SolicitudEstado> SolicitudEstados { get; set; }
        public virtual ICollection<SolicitudEstadosTurno> SolicitudEstadosTurnos { get; set; }
        public virtual ICollection<SolicitudPlazaDetalle> SolicitudPlazaDetalles { get; set; }
    }
}
