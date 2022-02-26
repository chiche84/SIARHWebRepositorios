using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class Permutum
    {
        public Permutum()
        {
            PermutaServicios = new HashSet<PermutaServicio>();
        }

        public int IdPermuta { get; set; }
        public int IdOrganizacionA { get; set; }
        public int IdHistoriaOrgA { get; set; }
        public int IdPersonaA { get; set; }
        public int IdOrganizacionB { get; set; }
        public int IdHistoriaOrgB { get; set; }
        public int IdPersonaB { get; set; }
        public DateTime FechaDesde { get; set; }
        public DateTime? FechaHasta { get; set; }
        public int? IdTerminoLectivo { get; set; }
        public bool? EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }
        public int IdOrgNivelEducativoA { get; set; }
        public int IdOrgNivelEducativoB { get; set; }
        public int? IdExpteCreacion { get; set; }
        public int? IdInstrumentoLegal { get; set; }
        public bool EstaFinalizada { get; set; }
        public bool EsDefinitiva { get; set; }

        public virtual Organizacion Id { get; set; } = null!;
        public virtual InstrumentoLegal? IdInstrumentoLegalNavigation { get; set; }
        public virtual Organizacion IdNavigation { get; set; } = null!;
        public virtual OrganizacionNivelEducativo IdOrgNivelEducativoANavigation { get; set; } = null!;
        public virtual OrganizacionNivelEducativo IdOrgNivelEducativoBNavigation { get; set; } = null!;
        public virtual Persona IdPersonaANavigation { get; set; } = null!;
        public virtual Persona IdPersonaBNavigation { get; set; } = null!;
        public virtual ICollection<PermutaServicio> PermutaServicios { get; set; }
    }
}
