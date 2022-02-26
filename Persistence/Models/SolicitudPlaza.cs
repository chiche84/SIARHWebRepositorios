using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    /// <summary>
    /// Solicitud de habilitación de plazas
    /// </summary>
    public partial class SolicitudPlaza
    {
        public SolicitudPlaza()
        {
            SolicitudEstados = new HashSet<SolicitudEstado>();
            SolicitudPlazaDetalles = new HashSet<SolicitudPlazaDetalle>();
        }

        /// <summary>
        /// Identificador de solicitud, autoincremental
        /// </summary>
        public int IdSolicitudPlaza { get; set; }
        /// <summary>
        /// Numero de resolucion correspondiente a la habilitacion de plazas solicitadas. Este campo es completado en la fase de habilitacion
        /// </summary>
        public int? IdInstrumentoLegalHab { get; set; }
        /// <summary>
        /// Clave foranea. Codigo de organizacion solicitante
        /// </summary>
        public int IdOrganizacion { get; set; }
        public int IdHistoriaOrg { get; set; }
        public int? IdOrganizacionNivelEduc { get; set; }
        /// <summary>
        /// Total de alumnos, si se trata de un establecimiento educativo 
        /// </summary>
        public int? MatriculaMujeres { get; set; }
        public int? MatriculaVarones { get; set; }
        /// <summary>
        /// Cantidad de divisiones que posee la organizacion
        /// </summary>
        public int? CantDivisiones { get; set; }
        /// <summary>
        /// Observaciones
        /// </summary>
        public string? Observacion { get; set; }
        /// <summary>
        /// Fecha de alta del registro de la solicitud en el sistema 
        /// </summary>
        public DateTime FechaCreacion { get; set; }
        /// <summary>
        /// Campo para borrado logico: Valor 0: falso; 1: verdadero
        /// </summary>
        public bool? EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }
        /// <summary>
        /// Clave foranea. Identificador del usuario que creo la solicitud
        /// </summary>
        public int? IdUsuarioCreador { get; set; }
        /// <summary>
        /// Año para le cuál se solicita la creación de plazas
        /// </summary>
        public int? Anio { get; set; }
        public int? IdTipoSolicitud { get; set; }
        public int? IdEjercicio { get; set; }
        public int? NumeroSolicitud { get; set; }

        public virtual Organizacion Id { get; set; } = null!;
        public virtual RefEjercicio? IdEjercicioNavigation { get; set; }
        public virtual InstrumentoLegal? IdInstrumentoLegalHabNavigation { get; set; }
        public virtual OrganizacionNivelEducativo? IdOrganizacionNivelEducNavigation { get; set; }
        public virtual RefTipoSolicitud? IdTipoSolicitudNavigation { get; set; }
        public virtual ICollection<SolicitudEstado> SolicitudEstados { get; set; }
        public virtual ICollection<SolicitudPlazaDetalle> SolicitudPlazaDetalles { get; set; }
    }
}
