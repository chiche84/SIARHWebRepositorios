using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    /// <summary>
    /// Organizaciones por edificio
    /// </summary>
    public partial class EdificioOrganizacion
    {
        public int IdEdificioOrganizacion { get; set; }
        /// <summary>
        /// Clave foranea de la tabla Edificio, forma parte de la clave combinada que identifica la/s organizacion/es que se encuentran en un edificio.
        /// </summary>
        public int IdEdificio { get; set; }
        /// <summary>
        /// Clave foranea de la tabla Organizacion, forma parte de la clave combinada que identifica la/s organizacion/es que se encuentran en un edificio.
        /// </summary>
        public int IdOrganizacion { get; set; }
        public int IdHistoriaOrg { get; set; }
        /// <summary>
        /// Identifica si el registro esta activo. 0=FALSO y 1=VERDADERO.
        /// </summary>
        public bool? EstaActivo { get; set; }
        /// <summary>
        /// Almacena la fecha de alta del registro.
        /// </summary>
        public DateTime? FechaAlta { get; set; }
        /// <summary>
        /// Almacena la fecha de desvinculación del agente como responsable
        /// </summary>
        public DateTime? FechaBaja { get; set; }
        /// <summary>
        /// Fecha de eliminación lógica
        /// </summary>
        public DateTime? FechaEliminacion { get; set; }
        public string? Observaciones { get; set; }

        public virtual Organizacion Id { get; set; } = null!;
        public virtual Edificio IdEdificioNavigation { get; set; } = null!;
    }
}
