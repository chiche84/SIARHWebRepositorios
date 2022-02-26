using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class SolicitudDetalle
    {
        public SolicitudDetalle()
        {
            SolicitudDetalleDesignacionIdSolicitudDetalleSitExtNavigations = new HashSet<SolicitudDetalleDesignacion>();
            SubServicios = new HashSet<SubServicio>();
        }

        public int IdSolicitudDetalle { get; set; }
        /// <summary>
        /// Identificador de cabecera de solicitud
        /// </summary>
        public int IdSolicitudLegajo { get; set; }
        /// <summary>
        /// Clave foranea. Identificador de agente
        /// </summary>
        public int? IdPersona { get; set; }
        public int IdMovimiento { get; set; }
        /// <summary>
        /// Clave foranea Identificador del servicio al cual está asociado este subservicio
        /// </summary>
        public int? IdServicio { get; set; }
        /// <summary>
        /// Clave foranea. Identificador del instrumento legal que avala el subservicio
        /// </summary>
        public int? IdInstrumentoLegal { get; set; }
        /// <summary>
        /// Clave foranea. Identificador del expediente con el que se tramita la solicitud
        /// </summary>
        public int? IdExpteSolicitud { get; set; }
        /// <summary>
        /// Identificador de estado del detalle de solicitud
        /// </summary>
        public int? IdEstadoSolicitudLegajo { get; set; }
        /// <summary>
        /// Observacion del estado
        /// </summary>
        public string? ObsEstado { get; set; }
        /// <summary>
        /// Identificador del circuito que debe seguir la solicitud según su tipo.
        /// </summary>
        public int IdCircuitoEtapaLegajo { get; set; }
        /// <summary>
        /// Observaciones
        /// </summary>
        public string? Observaciones { get; set; }
        /// <summary>
        /// Campo para eliminaicón lógica.  
        /// </summary>
        public bool? EstaActivo { get; set; }
        /// <summary>
        /// Fecha de eliminación de la baja lógica
        /// </summary>
        public DateTime? FechaEliminacion { get; set; }

        public virtual CircuitoEtapaLegajo IdCircuitoEtapaLegajoNavigation { get; set; } = null!;
        public virtual RefEstadosSolicitudLegajo? IdEstadoSolicitudLegajoNavigation { get; set; }
        public virtual InstrumentoLegal? IdInstrumentoLegalNavigation { get; set; }
        public virtual RefMovimiento IdMovimientoNavigation { get; set; } = null!;
        public virtual Persona? IdPersonaNavigation { get; set; }
        public virtual Servicio? IdServicioNavigation { get; set; }
        public virtual SolicitudLegajo IdSolicitudLegajoNavigation { get; set; } = null!;
        public virtual Servicio? Servicio { get; set; }
        public virtual SolicitudDetalleBaja SolicitudDetalleBaja { get; set; } = null!;
        public virtual SolicitudDetalleCambioSr SolicitudDetalleCambioSr { get; set; } = null!;
        public virtual SolicitudDetalleDesignacion SolicitudDetalleDesignacionIdSolicitudDetalleNavigation { get; set; } = null!;
        public virtual SolicitudDetalleFrenteAlumno SolicitudDetalleFrenteAlumno { get; set; } = null!;
        public virtual SolicitudDetalleLicencium SolicitudDetalleLicencium { get; set; } = null!;
        public virtual SolicitudDetalleSitExt SolicitudDetalleSitExt { get; set; } = null!;
        public virtual SolicitudDetalleSuplente SolicitudDetalleSuplente { get; set; } = null!;
        public virtual SolicitudDetalleSuspension SolicitudDetalleSuspension { get; set; } = null!;
        public virtual ICollection<SolicitudDetalleDesignacion> SolicitudDetalleDesignacionIdSolicitudDetalleSitExtNavigations { get; set; }
        public virtual ICollection<SubServicio> SubServicios { get; set; }
    }
}
