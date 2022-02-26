using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class SolicitudDetalleSuspension
    {
        public int IdSolicitudDetalle { get; set; }
        /// <summary>
        /// Id  del SubServicio de Licencia que se Suspende
        /// </summary>
        public int IdSubServicio { get; set; }
        /// <summary>
        /// Fecha Hasta del SubServicio
        /// </summary>
        public DateTime FechaHasta { get; set; }
        /// <summary>
        /// Fecha de la Suspención
        /// </summary>
        public DateTime Fecha { get; set; }

        public virtual SolicitudDetalle IdSolicitudDetalleNavigation { get; set; } = null!;
    }
}
