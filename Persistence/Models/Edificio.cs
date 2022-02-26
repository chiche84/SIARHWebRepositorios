using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    /// <summary>
    /// Infraestructuras en donde se desempeñan las organizaciones
    /// </summary>
    public partial class Edificio
    {
        public Edificio()
        {
            EdificioOrganizacions = new HashSet<EdificioOrganizacion>();
        }

        /// <summary>
        /// Clave primaria, autoincrementable. Identificador del edificio.
        /// </summary>
        public int IdEdificio { get; set; }
        /// <summary>
        /// Nombre del edificio.
        /// </summary>
        public string EdificioDesc { get; set; } = null!;
        /// <summary>
        /// Codigo unico de infraestructura. Identifica a cada edificio univocamente a nivel nacional.
        /// </summary>
        public string? Cui { get; set; }
        /// <summary>
        /// Clave foranea de la tabla RefTipoEdificio, indica el tipo de edificio (escuela, municipio, hospital, etc.)
        /// </summary>
        public int IdTipoEdificio { get; set; }
        /// <summary>
        /// Domicilio actual donde se encuentra ubicado el edificio.
        /// </summary>
        public string? CalleDomicilio { get; set; }
        /// <summary>
        /// Clave foranea de la tabla Localidad. Identificador de la localidad a la que pertenece el edificio.
        /// </summary>
        public int IdLocalidad { get; set; }
        /// <summary>
        /// Registra la fecha de construccion del edificio.
        /// </summary>
        public DateTime? FechaConstruccion { get; set; }
        /// <summary>
        /// Almacena la superficie total del edificio en metros cuadrados.
        /// </summary>
        public double? Superficie { get; set; }
        /// <summary>
        /// Almacena la superficie libre del edificio en metros cuadrados.
        /// </summary>
        public double? SuperficieLibre { get; set; }
        /// <summary>
        /// Almacena la superficie que ocupan las aulas del edificio en metros cuadrados.
        /// </summary>
        public double? SuperficieAulas { get; set; }
        /// <summary>
        /// Almacena la superficie cubierta del edificio en metros cuadrados.
        /// </summary>
        public double? SuperficieCubierta { get; set; }
        /// <summary>
        /// Clave foranea de la tabla RefEstadoEdificio. Describe el estado del edificio (bueno, muy bueno, regular, etc.).
        /// </summary>
        public int IdEstadoEdificio { get; set; }
        /// <summary>
        /// Clave foranea de la tabla RefTipoTenencia. Describe el tipo de tenencia del edificio (propio, alquilado, cedido, etc.).
        /// </summary>
        public int IdTipoTenencia { get; set; }
        /// <summary>
        /// Campo para eliminación lógica. Valor 0 es igual a falso, valor 1 es igual a verdadero.
        /// </summary>
        public bool? EstaActivo { get; set; }
        /// <summary>
        /// Fecha en la que se dio de alta el edificio en el sistema.
        /// </summary>
        public DateTime FechaAlta { get; set; }
        /// <summary>
        /// Fecha en la que se dio de baja el edificio en el sistema.
        /// </summary>
        public DateTime? FechaBaja { get; set; }
        /// <summary>
        /// Numeración del edificio (domicilio)
        /// </summary>
        public string? NumeroDomicilio { get; set; }
        /// <summary>
        /// Barrio (domicilio)
        /// </summary>
        public string? BarrioDomicilio { get; set; }
        /// <summary>
        /// Descripción sobre la ubicación del edificio
        /// </summary>
        public string? Referencia { get; set; }
        /// <summary>
        /// Referencia de domicilio
        /// </summary>
        public string? Radio { get; set; }
        /// <summary>
        /// Referencia de domicilio
        /// </summary>
        public string? Fraccion { get; set; }
        /// <summary>
        /// Referencia de domicilio
        /// </summary>
        public string? CalleFondo { get; set; }
        /// <summary>
        /// Referencia de domicilio
        /// </summary>
        public string? CalleDerecha { get; set; }
        /// <summary>
        /// Referencia de domicilio
        /// </summary>
        public string? CalleIzquierda { get; set; }
        /// <summary>
        /// Coordenada geográfica
        /// </summary>
        public double? XLongitud { get; set; }
        /// <summary>
        /// Coordenada geográfica
        /// </summary>
        public double? YLatitud { get; set; }

        public virtual RefEstadoEdificio IdEstadoEdificioNavigation { get; set; } = null!;
        public virtual Localidad IdLocalidadNavigation { get; set; } = null!;
        public virtual RefTipoEdificio IdTipoEdificioNavigation { get; set; } = null!;
        public virtual RefTipoTenencium IdTipoTenenciaNavigation { get; set; } = null!;
        public virtual ICollection<EdificioOrganizacion> EdificioOrganizacions { get; set; }
    }
}
