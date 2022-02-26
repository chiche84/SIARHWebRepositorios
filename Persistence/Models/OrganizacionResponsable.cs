using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class OrganizacionResponsable
    {
        public int IdOrganizacionResponsable { get; set; }
        /// <summary>
        /// Parte de la clave
        /// </summary>
        public int IdOrganizacion { get; set; }
        public int IdHistoriaOrg { get; set; }
        public int IdPersona { get; set; }
        /// <summary>
        /// Fecha en la que se registra el agente resposable de la organizacion
        /// </summary>
        public DateTime? FechaAlta { get; set; }
        /// <summary>
        /// Fecha en la que el agente deja de ser responsable de la organizacion
        /// </summary>
        public DateTime? FechaBaja { get; set; }
        /// <summary>
        /// Instrumento legal de designación
        /// </summary>
        public int? IdInstrumentoLegal { get; set; }
        /// <summary>
        /// Campo para eliminación lógica
        /// </summary>
        public bool? EstaActivo { get; set; }
        /// <summary>
        /// Fecha de la eliminaicón lógica
        /// </summary>
        public DateTime? FechaEliminacion { get; set; }

        public virtual Organizacion Id { get; set; } = null!;
        public virtual InstrumentoLegal? IdInstrumentoLegalNavigation { get; set; }
        public virtual Persona IdPersonaNavigation { get; set; } = null!;
    }
}
