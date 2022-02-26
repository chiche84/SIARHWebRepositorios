using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class PersonaSumario
    {
        public PersonaSumario()
        {
            PerSumarioOrganizacions = new HashSet<PerSumarioOrganizacion>();
            PersonaSumarioDictamen = new HashSet<PersonaSumarioDictaman>();
            PersonaSumarioInstLegals = new HashSet<PersonaSumarioInstLegal>();
        }

        public int IdPersonaSumario { get; set; }
        public int IdPersona { get; set; }
        public int IdTipoSumario { get; set; }
        public DateTime? FechaInicioSumario { get; set; }
        public string AsuntoSumario { get; set; } = null!;
        public bool? EstadoFinalizado { get; set; }
        public bool? EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }
        public int? IdOrganizacionSumariante { get; set; }
        public int? IdHistoriaOrgSumariante { get; set; }

        public virtual Organizacion? Id { get; set; }
        public virtual Persona IdPersonaNavigation { get; set; } = null!;
        public virtual RefTipoSumario IdTipoSumarioNavigation { get; set; } = null!;
        public virtual ICollection<PerSumarioOrganizacion> PerSumarioOrganizacions { get; set; }
        public virtual ICollection<PersonaSumarioDictaman> PersonaSumarioDictamen { get; set; }
        public virtual ICollection<PersonaSumarioInstLegal> PersonaSumarioInstLegals { get; set; }
    }
}
