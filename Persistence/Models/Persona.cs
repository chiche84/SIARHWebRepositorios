using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    /// <summary>
    /// Datos personales
    /// </summary>
    public partial class Persona
    {
        public Persona()
        {
            OrganizacionResponsables = new HashSet<OrganizacionResponsable>();
            PermutumIdPersonaANavigations = new HashSet<Permutum>();
            PermutumIdPersonaBNavigations = new HashSet<Permutum>();
            PersonaSumarios = new HashSet<PersonaSumario>();
            PersonaTitulos = new HashSet<PersonaTitulo>();
            ServicioExternos = new HashSet<ServicioExterno>();
            Servicios = new HashSet<Servicio>();
            SolicitudDetalles = new HashSet<SolicitudDetalle>();
            SolicitudPlazaDesignacions = new HashSet<SolicitudPlazaDesignacion>();
            SolicitudTurnos = new HashSet<SolicitudTurno>();
            Usuarios = new HashSet<Usuario>();
        }

        /// <summary>
        /// Clave primaria, autoincrementable.Codigo identificador de persona
        /// </summary>
        public int IdPersona { get; set; }
        /// <summary>
        /// Nombre/s de la persona
        /// </summary>
        public string Nombre { get; set; } = null!;
        /// <summary>
        /// Apellido de la persona
        /// </summary>
        public string Apellido { get; set; } = null!;
        /// <summary>
        /// Sexo Femenino=F; Masculino=M
        /// </summary>
        public int? IdSexo { get; set; }
        /// <summary>
        /// Fecha de nacimiento de la persona
        /// </summary>
        public DateTime? FechaNacimiento { get; set; }
        /// <summary>
        /// prefijo del cuil. ej: 27
        /// </summary>
        public string? Cuil { get; set; }
        /// <summary>
        /// Numero de documento
        /// </summary>
        public int? Documento { get; set; }
        /// <summary>
        /// Tipo de documento. Ej: 1. DNI, 2. L.C.
        /// </summary>
        public int? IdTipoDocumento { get; set; }
        /// <summary>
        /// Describe si el Cuil del agente esta validado o verificado
        /// </summary>
        public bool? EstaChequeadoCuil { get; set; }
        /// <summary>
        /// Telefono 
        /// </summary>
        public string? Telefono { get; set; }
        /// <summary>
        /// Dirección de correo electrónico
        /// </summary>
        public string? Mail { get; set; }
        /// <summary>
        /// Estado civil
        /// </summary>
        public int? IdEstadoCivil { get; set; }
        /// <summary>
        /// Fecha de fallecimiento
        /// </summary>
        public DateTime? FechaFallecimiento { get; set; }
        /// <summary>
        /// Nacionalidad
        /// </summary>
        public int? IdPaisNacionalidad { get; set; }
        /// <summary>
        /// Nivel Académico. Ej: 1. Primario; 2. Secundario, etc.
        /// </summary>
        public int? IdNivelEducativo { get; set; }
        /// <summary>
        /// Campo para eliminación lógica. Valor 0 es igual a falso, valor 1 es igual a verdadero
        /// </summary>
        public bool? EstaActivo { get; set; }
        /// <summary>
        /// Fecha en la que se da de baja a la persona
        /// </summary>
        public DateTime? FechaEliminacion { get; set; }
        public string? DomicilioCalle { get; set; }
        public string? DomicilioBarrio { get; set; }
        public string? DomicilioNro { get; set; }
        public string? DomicilioPiso { get; set; }
        public string? DomicilioDpto { get; set; }
        /// <summary>
        /// Clave foranea, localidad
        /// </summary>
        public int? IdLocalidad { get; set; }
        public string? Observaciones { get; set; }
        public bool? EstaVivo { get; set; }
        public bool? AgEsJubilado { get; set; }
        public DateTime? AgFechaJubilacion { get; set; }
        public DateTime? AgFechaAlta { get; set; }
        public DateTime? AgFechaBaja { get; set; }
        public int? IdLocalidadNacimiento { get; set; }

        public virtual RefEstadoCivil? IdEstadoCivilNavigation { get; set; }
        public virtual Localidad? IdLocalidadNacimientoNavigation { get; set; }
        public virtual Localidad? IdLocalidadNavigation { get; set; }
        public virtual RefNivelEducativo? IdNivelEducativoNavigation { get; set; }
        public virtual RefPaisNacionalidad? IdPaisNacionalidadNavigation { get; set; }
        public virtual RefSexo? IdSexoNavigation { get; set; }
        public virtual RefTipoDocumento? IdTipoDocumentoNavigation { get; set; }
        public virtual ICollection<OrganizacionResponsable> OrganizacionResponsables { get; set; }
        public virtual ICollection<Permutum> PermutumIdPersonaANavigations { get; set; }
        public virtual ICollection<Permutum> PermutumIdPersonaBNavigations { get; set; }
        public virtual ICollection<PersonaSumario> PersonaSumarios { get; set; }
        public virtual ICollection<PersonaTitulo> PersonaTitulos { get; set; }
        public virtual ICollection<ServicioExterno> ServicioExternos { get; set; }
        public virtual ICollection<Servicio> Servicios { get; set; }
        public virtual ICollection<SolicitudDetalle> SolicitudDetalles { get; set; }
        public virtual ICollection<SolicitudPlazaDesignacion> SolicitudPlazaDesignacions { get; set; }
        public virtual ICollection<SolicitudTurno> SolicitudTurnos { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
