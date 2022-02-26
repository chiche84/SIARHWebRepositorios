using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class SolicitudDetalleSitExt
    {
        /// <summary>
        /// Identificador de cabecera de solicitud
        /// </summary>
        public int IdSolicitudDetalle { get; set; }
        /// <summary>
        /// Fecha a partir de la cual entra en vigencia el servicio generado por la situación extraordinaria
        /// </summary>
        public DateTime FechaDesde { get; set; }
        /// <summary>
        /// Fecha en la que termina la vigencia del servicio generado por la situación extraordinaria
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
        /// <summary>
        /// Organización destino en donde se generará el servicio (puede ser la misma organizaicón u otra distinta).
        /// </summary>
        public int IdOrganizacionDestino { get; set; }
        /// <summary>
        /// Histórico de organizaicón destino
        /// </summary>
        public int IdHistoriaOrgDestino { get; set; }
        public int? IdTerminoLectivo { get; set; }
        /// <summary>
        /// Clave foranea. Plaza destino en la que se realiza el traslado
        /// </summary>
        public int? IdPlazaDestino { get; set; }

        public virtual Organizacion Id { get; set; } = null!;
        public virtual Plaza? IdPlazaDestinoNavigation { get; set; }
        public virtual SolicitudDetalle IdSolicitudDetalleNavigation { get; set; } = null!;
        public virtual TerminoLectivo? IdTerminoLectivoNavigation { get; set; }
    }
}
