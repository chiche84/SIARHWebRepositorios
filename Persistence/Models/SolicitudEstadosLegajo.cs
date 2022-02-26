using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    /// <summary>
    /// Registra el historial de estados por los que pasó una solicitud y la parte interviniente que registró dicho estado
    /// </summary>
    public partial class SolicitudEstadosLegajo
    {
        /// <summary>
        /// Campo clave, autoincremental
        /// </summary>
        public int IdSolicitudEstadoLegajo { get; set; }
        /// <summary>
        /// Identificadro de solicitud de legajo
        /// </summary>
        public int IdSolicitudLegajo { get; set; }
        /// <summary>
        /// Identificador de estado que puede asumir la solicitud de un agente (legajo) . Ejemplo: creada, presetnada, etc.. 
        /// </summary>
        public int IdEstadoSolicitudLegajo { get; set; }
        /// <summary>
        /// Identificador de parte interviniente del circuito que sigue un determinado tipo de solicitud
        /// </summary>
        public int? IdCircuitoEtapaLegajo { get; set; }
        /// <summary>
        /// Observaciones
        /// </summary>
        public string? Observacion { get; set; }
        /// <summary>
        /// Fecha en la que se registró el estado
        /// </summary>
        public DateTime FechaEstado { get; set; }
        public int? IdOrganizacion { get; set; }
        public int? IdHistoriaOrg { get; set; }
        public int? Orden { get; set; }
        public bool? EstaActivo { get; set; }

        public virtual CircuitoEtapaLegajo? IdCircuitoEtapaLegajoNavigation { get; set; }
        public virtual RefEstadosSolicitudLegajo IdEstadoSolicitudLegajoNavigation { get; set; } = null!;
        public virtual SolicitudLegajo IdSolicitudLegajoNavigation { get; set; } = null!;
    }
}
