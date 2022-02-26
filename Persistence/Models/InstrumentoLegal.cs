using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    /// <summary>
    /// Instrumento legal que avala algun movimiento, por ejemplo la designacion de un docente. En esta tabla se registra el numero del insturmento legal, y la descripcion que explica el movimiento.
    /// Cada instrumento legal tiene asociado un tipo (idTipoInstrumentoLegal), pueder ser una resolución, disposicion, norma, etc.
    /// </summary>
    public partial class InstrumentoLegal
    {
        public InstrumentoLegal()
        {
            InstrumentoLegalAdjuntos = new HashSet<InstrumentoLegalAdjunto>();
            Licencia = new HashSet<Licencium>();
            OrganizacionResponsables = new HashSet<OrganizacionResponsable>();
            OrganizacionxInstrumentoLegals = new HashSet<OrganizacionxInstrumentoLegal>();
            Permuta = new HashSet<Permutum>();
            PersonaSumarioInstLegals = new HashSet<PersonaSumarioInstLegal>();
            PlanEstudioCohortes = new HashSet<PlanEstudioCohorte>();
            PlazaIdInstrumentoLegalBajaNavigations = new HashSet<Plaza>();
            PlazaIdInstrumentoLegalCreacionNavigations = new HashSet<Plaza>();
            ServicioIdInstrumentoLegalAltaNavigations = new HashSet<Servicio>();
            ServicioIdInstrumentoLegalBajaNavigations = new HashSet<Servicio>();
            SolicitudDetalles = new HashSet<SolicitudDetalle>();
            SolicitudPlazaDesignacions = new HashSet<SolicitudPlazaDesignacion>();
            SolicitudPlazaDetalleIdInstrumentoLegalBajaNavigations = new HashSet<SolicitudPlazaDetalle>();
            SolicitudPlazaDetalleIdInstrumentoLegalCreacionNavigations = new HashSet<SolicitudPlazaDetalle>();
            SolicitudPlazaSitExtIdInstrumentoLegalBajaNavigations = new HashSet<SolicitudPlazaSitExt>();
            SolicitudPlazaSitExtIdInstrumentoLegalCreacionNavigations = new HashSet<SolicitudPlazaSitExt>();
            SolicitudPlazas = new HashSet<SolicitudPlaza>();
            SubServicios = new HashSet<SubServicio>();
        }

        /// <summary>
        /// Clave primaria, autoincrementable. Código identificador de Instrumento legal
        /// </summary>
        public int IdInstrumentoLegal { get; set; }
        /// <summary>
        /// Número de Instrumento legal
        /// </summary>
        public string InstrumentoLegalDesc { get; set; } = null!;
        /// <summary>
        /// Clave foranea, identificador de tipo de Instrumento Legal
        /// </summary>
        public int IdTipoInstrumentoLegal { get; set; }
        /// <summary>
        /// Detalle del instrumento legal
        /// </summary>
        public string? Descripcion { get; set; }
        /// <summary>
        /// Clave para eliminacion logica. Valor 0 es igual a falso, valor 1 es igual a verdadero
        /// </summary>
        public bool? EstaActivo { get; set; }
        /// <summary>
        /// Fecha en la que deja de estar activo el instrumento legal
        /// </summary>
        public DateTime? FechaEliminacion { get; set; }

        public virtual RefTipoInstrumentoLegal IdTipoInstrumentoLegalNavigation { get; set; } = null!;
        public virtual ICollection<InstrumentoLegalAdjunto> InstrumentoLegalAdjuntos { get; set; }
        public virtual ICollection<Licencium> Licencia { get; set; }
        public virtual ICollection<OrganizacionResponsable> OrganizacionResponsables { get; set; }
        public virtual ICollection<OrganizacionxInstrumentoLegal> OrganizacionxInstrumentoLegals { get; set; }
        public virtual ICollection<Permutum> Permuta { get; set; }
        public virtual ICollection<PersonaSumarioInstLegal> PersonaSumarioInstLegals { get; set; }
        public virtual ICollection<PlanEstudioCohorte> PlanEstudioCohortes { get; set; }
        public virtual ICollection<Plaza> PlazaIdInstrumentoLegalBajaNavigations { get; set; }
        public virtual ICollection<Plaza> PlazaIdInstrumentoLegalCreacionNavigations { get; set; }
        public virtual ICollection<Servicio> ServicioIdInstrumentoLegalAltaNavigations { get; set; }
        public virtual ICollection<Servicio> ServicioIdInstrumentoLegalBajaNavigations { get; set; }
        public virtual ICollection<SolicitudDetalle> SolicitudDetalles { get; set; }
        public virtual ICollection<SolicitudPlazaDesignacion> SolicitudPlazaDesignacions { get; set; }
        public virtual ICollection<SolicitudPlazaDetalle> SolicitudPlazaDetalleIdInstrumentoLegalBajaNavigations { get; set; }
        public virtual ICollection<SolicitudPlazaDetalle> SolicitudPlazaDetalleIdInstrumentoLegalCreacionNavigations { get; set; }
        public virtual ICollection<SolicitudPlazaSitExt> SolicitudPlazaSitExtIdInstrumentoLegalBajaNavigations { get; set; }
        public virtual ICollection<SolicitudPlazaSitExt> SolicitudPlazaSitExtIdInstrumentoLegalCreacionNavigations { get; set; }
        public virtual ICollection<SolicitudPlaza> SolicitudPlazas { get; set; }
        public virtual ICollection<SubServicio> SubServicios { get; set; }
    }
}
