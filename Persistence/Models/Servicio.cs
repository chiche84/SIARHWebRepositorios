using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    /// <summary>
    /// Servicio o cargos que ocupa un agente
    /// </summary>
    public partial class Servicio
    {
        public Servicio()
        {
            PermutaServicioIdServicioDestinoNavigations = new HashSet<PermutaServicio>();
            PermutaServicioIdServicioOrigenNavigations = new HashSet<PermutaServicio>();
            SolicitudDetalles = new HashSet<SolicitudDetalle>();
            SubServicioIdServicioDestinoNavigations = new HashSet<SubServicio>();
            SubServicioIdServicioNavigations = new HashSet<SubServicio>();
            SumarioDictamenServicios = new HashSet<SumarioDictamenServicio>();
        }

        /// <summary>
        /// Clave primaria, autoincrementable. Identificador de un servicio de un agente
        /// </summary>
        public int IdServicio { get; set; }
        /// <summary>
        /// Clave foranea. Identificador de agente
        /// </summary>
        public int IdPersona { get; set; }
        /// <summary>
        /// Clave foranea. Identificador de la plaza asociada al servicio
        /// </summary>
        public int IdPlaza { get; set; }
        public int? IdPlazaHistoria { get; set; }
        /// <summary>
        /// Clave foranea. Identificador de situacion de revista. Ejemplo: 1. Titular 2. Interino
        /// </summary>
        public int IdSituacionRevista { get; set; }
        /// <summary>
        /// Fecha desde la cual se inicia el servicio del agente
        /// </summary>
        public DateTime FechaDesde { get; set; }
        /// <summary>
        /// Fecha en la que finaliza el servicio de un agente
        /// </summary>
        public DateTime? FechaHasta { get; set; }
        /// <summary>
        /// Campo para eliminación lógica. Valor 0 es igual a falso, valor 1 es igual a verdadero
        /// </summary>
        public bool? EstaActivo { get; set; }
        /// <summary>
        /// Clave foranea. Identificador de tipo de servicio. Ejemplo 1. De base; 2. Sujeto a licencia
        /// </summary>
        public int? IdTipoServicio { get; set; }
        /// <summary>
        /// Clave foranea, guarda el instrumento legal que avala el inicio del servicio
        /// </summary>
        public int? IdInstrumentoLegalAlta { get; set; }
        /// <summary>
        /// Clave foranea, guarda el expediente que tramita el inicio del servicio
        /// </summary>
        public int? IdExpteAlta { get; set; }
        /// <summary>
        /// Clave foranea, guarda el instrumento legal que avala la finalización del servicio
        /// </summary>
        public int? IdInstrumentoLegalBaja { get; set; }
        /// <summary>
        /// Clave foranea, guarda el expediente de que tramita la finalización del servicio
        /// </summary>
        public int? IdExpteBaja { get; set; }
        /// <summary>
        /// Clave foranea. Indentificador del motivo de alta de servicio. Ejemplo: 1. Designacion por concurso normal; 2.Designacion sinconcurso
        /// </summary>
        public int IdMotivoAlta { get; set; }
        /// <summary>
        /// Clave foranea. Identificador de la causa o motivo de la baja del servicio. Ejemplo: 1. Termino, 2. Renuncia
        /// </summary>
        public int? IdMotivoBaja { get; set; }
        /// <summary>
        /// Fecha de eliminaicón lógica
        /// </summary>
        public DateTime? Fechaeliminacion { get; set; }
        public int? IdTituloHabilitante { get; set; }
        public string? Observaciones { get; set; }
        /// <summary>
        /// Identificador de solicitud de designación que generó el servicio
        /// </summary>
        public int? IdSolicitudDetalleDesignacion { get; set; }
        public int? IdTerminoLectivo { get; set; }
        public bool? EsEditable { get; set; }
        /// <summary>
        /// Subservicio de licencia que da origen al nuevo servicio (suplente)
        /// </summary>
        public int? IdSubservicioOrigen { get; set; }
        public bool AdmiteSuplente { get; set; }
        /// <summary>
        /// Subservicio de Situación Extraordinaria que da origen al nuevo servicio 
        /// </summary>
        public int? IdSubservicioSeorigen { get; set; }
        public bool EstaFrenteAlumnoInicial { get; set; }

        public virtual InstrumentoLegal? IdInstrumentoLegalAltaNavigation { get; set; }
        public virtual InstrumentoLegal? IdInstrumentoLegalBajaNavigation { get; set; }
        public virtual RefMovimiento IdMotivoAltaNavigation { get; set; } = null!;
        public virtual Persona IdPersonaNavigation { get; set; } = null!;
        public virtual PlazaHistorium? IdPlazaNavigation { get; set; }
        public virtual RefSituacionRevistum IdSituacionRevistaNavigation { get; set; } = null!;
        public virtual SolicitudDetalle? IdSolicitudDetalleDesignacionNavigation { get; set; }
        public virtual RefTituloHabilitante? IdTituloHabilitanteNavigation { get; set; }
        public virtual ICollection<PermutaServicio> PermutaServicioIdServicioDestinoNavigations { get; set; }
        public virtual ICollection<PermutaServicio> PermutaServicioIdServicioOrigenNavigations { get; set; }
        public virtual ICollection<SolicitudDetalle> SolicitudDetalles { get; set; }
        public virtual ICollection<SubServicio> SubServicioIdServicioDestinoNavigations { get; set; }
        public virtual ICollection<SubServicio> SubServicioIdServicioNavigations { get; set; }
        public virtual ICollection<SumarioDictamenServicio> SumarioDictamenServicios { get; set; }
    }
}
