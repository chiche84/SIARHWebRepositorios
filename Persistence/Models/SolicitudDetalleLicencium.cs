using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    /// <summary>
    /// Detalle de solicitudes de licencias
    /// </summary>
    public partial class SolicitudDetalleLicencium
    {
        /// <summary>
        /// Identificador de cabecera de solicitud
        /// </summary>
        public int IdSolicitudDetalle { get; set; }
        /// <summary>
        /// Fecha a partir de la cual entra en vigencia el subservicio
        /// </summary>
        public DateTime FechaDesde { get; set; }
        /// <summary>
        /// Fecha en la que termina la vigencia del subservicio
        /// </summary>
        public DateTime? FechaHasta { get; set; }
        /// <summary>
        /// Años de antigüedad
        /// </summary>
        public int? CantAños { get; set; }
        /// <summary>
        /// Meses de antigüedad
        /// </summary>
        public int? CantMeses { get; set; }
        /// <summary>
        /// Días de antigüedad
        /// </summary>
        public int? CantDias { get; set; }
        public int? DiasLicencia { get; set; }
        public int? IdTerminoLectivo { get; set; }

        public virtual SolicitudDetalle IdSolicitudDetalleNavigation { get; set; } = null!;
        public virtual TerminoLectivo? IdTerminoLectivoNavigation { get; set; }
    }
}
