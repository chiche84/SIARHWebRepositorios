using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class SolicitudEstado
    {
        /// <summary>
        /// Campo clave, identificador de la relación entre solicitud y estado
        /// </summary>
        public int IdEstadoSol { get; set; }
        /// <summary>
        /// Identificador de solicitud
        /// </summary>
        public int IdSolicitudPlaza { get; set; }
        /// <summary>
        /// Identificador de estado. Ejemplo: 1- Pendiente 2-Presentada, 3- Aprobada
        /// </summary>
        public int IdEstadoSolicitud { get; set; }
        /// <summary>
        /// Identificador de parte interviniente del circuito de habilitación. Ejemplo: 1. Organización, 2. Supervisión regional. etc.  
        /// </summary>
        public int IdCircuitoSol { get; set; }
        /// <summary>
        /// Descripción u observación del estado de la solicitud
        /// </summary>
        public string? Observacion { get; set; }
        /// <summary>
        /// Fecha en la que se produjo le cambio de estado de una solicitud
        /// </summary>
        public DateTime FechaEstado { get; set; }

        public virtual CircuitoSolicitudPlaza IdCircuitoSolNavigation { get; set; } = null!;
        public virtual RefEstadoSolicitud IdEstadoSolicitudNavigation { get; set; } = null!;
        public virtual SolicitudPlaza IdSolicitudPlazaNavigation { get; set; } = null!;
    }
}
