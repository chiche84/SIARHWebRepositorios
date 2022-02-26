using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class SolicitudDetalleCambioSr
    {
        public int IdSolicitudDetalle { get; set; }
        public int IdSituacionRevista { get; set; }
        public DateTime FechaDesde { get; set; }
        public DateTime? FechaHasta { get; set; }

        public virtual RefSituacionRevistum IdSituacionRevistaNavigation { get; set; } = null!;
        public virtual SolicitudDetalle IdSolicitudDetalleNavigation { get; set; } = null!;
    }
}
