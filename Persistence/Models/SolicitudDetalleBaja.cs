using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class SolicitudDetalleBaja
    {
        /// <summary>
        /// Identificador de cabecera de solicitud
        /// </summary>
        public int IdSolicitudDetalle { get; set; }
        /// <summary>
        /// Fecha a partir de la cual finaliza el servicio
        /// </summary>
        public DateTime Fecha { get; set; }
        /// <summary>
        /// fecha de Fin del Servicio antes de la Baja
        /// </summary>
        public DateTime FechaHasta { get; set; }

        public virtual SolicitudDetalle IdSolicitudDetalleNavigation { get; set; } = null!;
    }
}
