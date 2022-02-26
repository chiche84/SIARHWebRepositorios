using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    /// <summary>
    /// Entidad organizativa: establecimientos, direcciones, reparticciones, etc.
    /// </summary>
    public partial class Organizacion
    {
        public Organizacion()
        {
            CircuitoEtapaLegajos = new HashSet<CircuitoEtapaLegajo>();
            EdificioOrganizacions = new HashSet<EdificioOrganizacion>();
            InverseId = new HashSet<Organizacion>();
            NodosOrgIdNavigations = new HashSet<NodosOrg>();
            NodosOrgIds = new HashSet<NodosOrg>();
            OrganizacionNivelEducativos = new HashSet<OrganizacionNivelEducativo>();
            OrganizacionResponsables = new HashSet<OrganizacionResponsable>();
            OrganizacionTurnos = new HashSet<OrganizacionTurno>();
            OrganizacionxInstrumentoLegals = new HashSet<OrganizacionxInstrumentoLegal>();
            PerSumarioOrganizacions = new HashSet<PerSumarioOrganizacion>();
            PermutumIdNavigations = new HashSet<Permutum>();
            PermutumIds = new HashSet<Permutum>();
            PersonaSumarios = new HashSet<PersonaSumario>();
            PlanillaNovedades = new HashSet<PlanillaNovedade>();
            Plazas = new HashSet<Plaza>();
            ServicioExternos = new HashSet<ServicioExterno>();
            SolicitudDetalleSitExts = new HashSet<SolicitudDetalleSitExt>();
            SolicitudLegajos = new HashSet<SolicitudLegajo>();
            SolicitudPlazas = new HashSet<SolicitudPlaza>();
            SolicitudTurnos = new HashSet<SolicitudTurno>();
            UsuarioOrganizacions = new HashSet<UsuarioOrganizacion>();
        }

        /// <summary>
        /// Clave primaria, autoincrementable. Identificador de la organizacion
        /// </summary>
        public int IdOrganizacion { get; set; }
        public int IdHistoriaOrg { get; set; }
        /// <summary>
        /// Nombre o razon social de la organizacion
        /// </summary>
        public string OrganizacionDesc { get; set; } = null!;
        /// <summary>
        /// En caso de tratarse de un establecimiento educativo a éste se le asocia un numero identificatorio. Ejemplo: ESCUELA Nº &quot;65&quot; JOSE QUINTANA
        /// </summary>
        public string? NumeroOrganizacion { get; set; }
        /// <summary>
        /// Clave Unica de Establecimiento. Es un numero que identifica a cada una de las escuelas de la Argentina
        /// </summary>
        public int? Cue { get; set; }
        /// <summary>
        /// Valor numérico de dos dígitos que identifica un anexo de una organizacion 
        /// </summary>
        public int? Anexo { get; set; }
        public bool EsEducativo { get; set; }
        /// <summary>
        /// Clave foranea. Identificador de tipo de organizacion. Ejemplo:  Organizacion Educativa, organizacion no educativa, área, secretaría, oficina, etc.
        /// </summary>
        public int? IdTipoOrganizacion { get; set; }
        /// <summary>
        /// Direccion de correo electronico
        /// </summary>
        public string? EmailIntitucional { get; set; }
        /// <summary>
        /// Campo para eliminación lógica. Valor 0 es igual a falso, valor 1 es igual a verdadero
        /// </summary>
        public bool? EstaActivo { get; set; }
        /// <summary>
        /// Fecha de asignación de CUE
        /// </summary>
        public DateTime? FechaCreacion { get; set; }
        /// <summary>
        /// Fecha en la que el establecimietno da inicio a su funcionamiento.
        /// </summary>
        public DateTime? FechaAlta { get; set; }
        /// <summary>
        /// Fecha en la que la organización deja de funcionar
        /// </summary>
        public DateTime? FechaBaja { get; set; }
        /// <summary>
        /// Fecha en la que deja de estar activa la organizacion (eliminación lógica)
        /// </summary>
        public DateTime? FechaEliminacion { get; set; }
        /// <summary>
        /// Observaciones
        /// </summary>
        public string? Observaciones { get; set; }
        /// <summary>
        /// Clave autoreferencial. Identificador de la organizacion de la cual depende
        /// </summary>
        public int? IdDependenciaFuncional { get; set; }
        /// <summary>
        /// Clave foranea. Identificador de la zona geografica a la que pertenece. Ejemplo. zona 0, zona 1
        /// </summary>
        public int? IdZona { get; set; }
        /// <summary>
        /// Numero de telefono
        /// </summary>
        public string? Telefono { get; set; }
        /// <summary>
        /// Clave foranea. Identificador de jornada de la organizacion. Ejemplo Jornada simple, jornada completa
        /// </summary>
        public int? IdJornada { get; set; }
        /// <summary>
        /// Clave foranea. Identificador de la categoria de la organizacion. Ejemplo: Primera categoria, segunda categoria
        /// </summary>
        public int? IdCategoriaOrganizacion { get; set; }
        public DateTime? FechaChequeo { get; set; }
        /// <summary>
        /// Campo logico, indica si la organizacion fue chequeada, verficada o no. Valor 0 es igual a falso, valor 1 es igual a verdadero
        /// </summary>
        public bool EstaChequeada { get; set; }
        /// <summary>
        /// Clave foranea. Identificador de ambito de la organizacion. Ejemplo: privado, publico
        /// </summary>
        public int? IdAmbito { get; set; }
        /// <summary>
        /// Clave foranea. Identificador del tipo de educacion de la organizacion si es que  se trata de un establecimiento. Ejemplo: especial, comun
        /// </summary>
        public int? IdTipoEducacion { get; set; }
        /// <summary>
        /// Clave foranea. Identificador de la region educativa a la que pertenece la organizacion en caso de tratarse de un establecimiento educativo. Ejemplo: Region I, region IV
        /// </summary>
        public int? IdRegion { get; set; }
        /// <summary>
        /// Periodo escolar de la organizacion: comun, especial y de acuerdo al nivel educativo
        /// </summary>
        public int? IdTipoPeriodoEscolar { get; set; }
        /// <summary>
        /// Clave foranea. Identificador de tipo de subvención. Ej: Con subvencion privada, gestion social o sin subvencion
        /// </summary>
        public int? IdSubvencion { get; set; }
        /// <summary>
        /// Clave foranea. Identificador de la modalidad alimentaria de un establecimiento. Ej: comedor, merienda seca, albergue
        /// </summary>
        public int? IdModalidadAlimentaria { get; set; }
        /// <summary>
        /// Campo booleano que indica si es religioso o no.
        /// </summary>
        public bool EsConfesional { get; set; }
        /// <summary>
        /// Campo booleano. Indica si la organización es arancelada o no
        /// </summary>
        public bool EsArancelado { get; set; }
        /// <summary>
        /// Indica si la organización es interna o pertence al ministerio de educación como dependencia.  
        /// </summary>
        public bool? EsInterna { get; set; }
        /// <summary>
        /// Indica si la organización es creada para su utilizacion en el Sistema de Expedientes
        /// </summary>
        public bool? ParaGdocs { get; set; }
        public int? IdOrganizacionPadre { get; set; }
        public int? IdHistoriaOrgPadre { get; set; }
        public bool? EsEducacionDiferencial { get; set; }
        public string? CodigoLiquidacion { get; set; }
        public decimal? PorcSubvencion { get; set; }

        public virtual Organizacion? Id { get; set; }
        public virtual RefAmbito? IdAmbitoNavigation { get; set; }
        public virtual RefCategoriaOrganizacion? IdCategoriaOrganizacionNavigation { get; set; }
        public virtual RefDependenciaFuncional? IdDependenciaFuncionalNavigation { get; set; }
        public virtual RefJornadum? IdJornadaNavigation { get; set; }
        public virtual RefModalidadAlimentarium? IdModalidadAlimentariaNavigation { get; set; }
        public virtual RefRegion? IdRegionNavigation { get; set; }
        public virtual RefSubvencion? IdSubvencionNavigation { get; set; }
        public virtual RefTipoEducacion? IdTipoEducacionNavigation { get; set; }
        public virtual RefTipoOrganizacion? IdTipoOrganizacionNavigation { get; set; }
        public virtual RefTipoPeriodoEscolar? IdTipoPeriodoEscolarNavigation { get; set; }
        public virtual RefZona? IdZonaNavigation { get; set; }
        public virtual ICollection<CircuitoEtapaLegajo> CircuitoEtapaLegajos { get; set; }
        public virtual ICollection<EdificioOrganizacion> EdificioOrganizacions { get; set; }
        public virtual ICollection<Organizacion> InverseId { get; set; }
        public virtual ICollection<NodosOrg> NodosOrgIdNavigations { get; set; }
        public virtual ICollection<NodosOrg> NodosOrgIds { get; set; }
        public virtual ICollection<OrganizacionNivelEducativo> OrganizacionNivelEducativos { get; set; }
        public virtual ICollection<OrganizacionResponsable> OrganizacionResponsables { get; set; }
        public virtual ICollection<OrganizacionTurno> OrganizacionTurnos { get; set; }
        public virtual ICollection<OrganizacionxInstrumentoLegal> OrganizacionxInstrumentoLegals { get; set; }
        public virtual ICollection<PerSumarioOrganizacion> PerSumarioOrganizacions { get; set; }
        public virtual ICollection<Permutum> PermutumIdNavigations { get; set; }
        public virtual ICollection<Permutum> PermutumIds { get; set; }
        public virtual ICollection<PersonaSumario> PersonaSumarios { get; set; }
        public virtual ICollection<PlanillaNovedade> PlanillaNovedades { get; set; }
        public virtual ICollection<Plaza> Plazas { get; set; }
        public virtual ICollection<ServicioExterno> ServicioExternos { get; set; }
        public virtual ICollection<SolicitudDetalleSitExt> SolicitudDetalleSitExts { get; set; }
        public virtual ICollection<SolicitudLegajo> SolicitudLegajos { get; set; }
        public virtual ICollection<SolicitudPlaza> SolicitudPlazas { get; set; }
        public virtual ICollection<SolicitudTurno> SolicitudTurnos { get; set; }
        public virtual ICollection<UsuarioOrganizacion> UsuarioOrganizacions { get; set; }
    }
}
