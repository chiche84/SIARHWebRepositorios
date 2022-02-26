using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    /// <summary>
    /// Subservicios ligados a un servicio
    /// </summary>
    public partial class SubServicio
    {
        public SubServicio()
        {
            Novedads = new HashSet<Novedad>();
        }

        /// <summary>
        /// Clave primaria, autoincrementable. Identificador de Subservicio
        /// </summary>
        public int IdSubServicio { get; set; }
        /// <summary>
        ///  Clave foranea. Identificador de Servicio al cual esta asociado este subservicio
        /// </summary>
        public int IdServicio { get; set; }
        /// <summary>
        /// Fecha a partir de la cual entra en vigencia el subservicio
        /// </summary>
        public DateTime FechaDesde { get; set; }
        /// <summary>
        /// Fecha en la que termina la vigencia del subservicio
        /// </summary>
        public DateTime? FechaHasta { get; set; }
        /// <summary>
        /// Clave foranea. Identificador del instrumento legal que avala el subservicio
        /// </summary>
        public int? IdInstrumentoLegal { get; set; }
        /// <summary>
        /// Clave foranea, identificador del expediente con el que se tramita la creacion del sub servicio.
        /// </summary>
        public int? IdExpteCreacion { get; set; }
        /// <summary>
        /// Clave foranea. Identificador de movimiento. Ejemplo: 1. Alta; 2. Baja; 3.Licencia; 4. Situación extraordinaria (Slector de tabla)
        /// </summary>
        public int IdMovimiento { get; set; }
        /// <summary>
        /// Clave foranea. Identificador del servicio ligado, en caso de dar inicio un nuevo servicio, por situación extraordinaria por ejemplo.
        /// </summary>
        public int? IdServicioDestino { get; set; }
        /// <summary>
        /// Clave foranea. Identificador de adicional. Ejemplo: 1. Adicional por mayor horario; 2. Adicional por mayor responsabilidad
        /// </summary>
        public int? IdAdicional { get; set; }
        /// <summary>
        /// Indica si el servicio se realiza frente a alumnos. 
        /// </summary>
        public bool EstaFrenteAlumno { get; set; }
        /// <summary>
        /// Clave foranea. Identificador del detalle de solicitud que generó el subservicio (SPuede hacer referencia a las tablas olicitudDetalleLicSe, SolicitudDetalleDesignación, según idMovimiento)
        /// </summary>
        public int? IdSolicitudDetalle { get; set; }
        /// <summary>
        /// Campo para eliminación lógica. Valor 0 es igual a falso, valor 1 es igual a verdadero
        /// </summary>
        public bool? EstaActivo { get; set; }
        /// <summary>
        /// Fecha en la que se realiza la eliminación lógica
        /// </summary>
        public DateTime? FechaEliminacion { get; set; }
        public int? IdTerminoLectivo { get; set; }
        /// <summary>
        /// True si el subservicio de licencia ya tiene un suplente designado durante la totalidad del periodo de la licencia
        /// </summary>
        public bool? TieneSuplente { get; set; }
        public int? IdSubServicioVinculado { get; set; }

        public virtual RefAdicional? IdAdicionalNavigation { get; set; }
        public virtual InstrumentoLegal? IdInstrumentoLegalNavigation { get; set; }
        public virtual RefMovimiento IdMovimientoNavigation { get; set; } = null!;
        public virtual Servicio? IdServicioDestinoNavigation { get; set; }
        public virtual Servicio IdServicioNavigation { get; set; } = null!;
        public virtual SolicitudDetalle? IdSolicitudDetalleNavigation { get; set; }
        public virtual TerminoLectivo? IdTerminoLectivoNavigation { get; set; }
        public virtual ICollection<Novedad> Novedads { get; set; }
    }
}
