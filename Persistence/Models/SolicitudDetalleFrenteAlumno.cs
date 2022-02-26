using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class SolicitudDetalleFrenteAlumno
    {
        public int IdSolicitudDetalle { get; set; }
        public DateTime Fecha { get; set; }
        public bool EstaFrenteAlumno { get; set; }
        /// <summary>
        /// Funcion a cumplir
        /// </summary>
        public string? Funcion { get; set; }

        public virtual SolicitudDetalle IdSolicitudDetalleNavigation { get; set; } = null!;
    }
}
