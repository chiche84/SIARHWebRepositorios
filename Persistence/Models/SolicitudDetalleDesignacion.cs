using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class SolicitudDetalleDesignacion
    {
        /// <summary>
        /// Identificador de la cabecera de solicitud
        /// </summary>
        public int IdSolicitudDetalle { get; set; }
        public DateTime FechaDesde { get; set; }
        public DateTime? FechaHasta { get; set; }
        /// <summary>
        /// Identificador de la plaza vinculada al servicio
        /// </summary>
        public int IdPlaza { get; set; }
        /// <summary>
        /// Identificador de situación de revista:. Ejemplo: 1. Titular, 2. Interino
        /// </summary>
        public int? IdSituacionRevista { get; set; }
        /// <summary>
        /// Identificador de termino lectivo ITL (fecha hasta)
        /// </summary>
        public int? IdTerminoLectivo { get; set; }
        /// <summary>
        /// Identificador de tipo de servicio, ejemplo: 1. de base , 2. sujeto a licencia
        /// </summary>
        public int? IdTipoServicio { get; set; }
        /// <summary>
        /// Identificador de título habilitante 
        /// </summary>
        public int? IdTituloHabilitante { get; set; }
        /// <summary>
        /// Indica si el servicio se cumple frente a alumnos
        /// </summary>
        public bool EstaFrenteAlumno { get; set; }
        /// <summary>
        /// Identificador de tipo de documento. En caso de que el agente no exista en la base de datos
        /// </summary>
        public int? IdTipoDocumento { get; set; }
        /// <summary>
        /// nro de documento
        /// </summary>
        public int? NroDocumento { get; set; }
        /// <summary>
        /// Cuil
        /// </summary>
        public string? Cuil { get; set; }
        /// <summary>
        /// Apellido del agente
        /// </summary>
        public string? Apellido { get; set; }
        /// <summary>
        /// Nombre del agente
        /// </summary>
        public string? Nombre { get; set; }
        /// <summary>
        /// Identificador de sexo del agente
        /// </summary>
        public int? IdSexo { get; set; }
        /// <summary>
        /// Identificador del detalle de solicitud de situacióin extraordinaria, en caso de idTipoSolicitud = 7 Alta por situación extraordinaria
        /// </summary>
        public int? IdSolicitudDetalleSitExt { get; set; }
        public int IdPlazaHistoria { get; set; }
        public bool AdmiteSuplente { get; set; }

        public virtual PlazaHistorium IdPlazaNavigation { get; set; } = null!;
        public virtual RefSexo? IdSexoNavigation { get; set; }
        public virtual RefSituacionRevistum? IdSituacionRevistaNavigation { get; set; }
        public virtual SolicitudDetalle IdSolicitudDetalleNavigation { get; set; } = null!;
        public virtual SolicitudDetalle? IdSolicitudDetalleSitExtNavigation { get; set; }
        public virtual TerminoLectivo? IdTerminoLectivoNavigation { get; set; }
        public virtual RefTipoDocumento? IdTipoDocumentoNavigation { get; set; }
        public virtual RefTipoServicio? IdTipoServicioNavigation { get; set; }
        public virtual RefTituloHabilitante? IdTituloHabilitanteNavigation { get; set; }
    }
}
