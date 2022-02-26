using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class OrganizacionNivelEducativo
    {
        public OrganizacionNivelEducativo()
        {
            PermutumIdOrgNivelEducativoANavigations = new HashSet<Permutum>();
            PermutumIdOrgNivelEducativoBNavigations = new HashSet<Permutum>();
            PlanUnidads = new HashSet<PlanUnidad>();
            PlanillaNovedades = new HashSet<PlanillaNovedade>();
            Plazas = new HashSet<Plaza>();
            SolicitudLegajos = new HashSet<SolicitudLegajo>();
            SolicitudPlazas = new HashSet<SolicitudPlaza>();
            TableroOrganizacions = new HashSet<TableroOrganizacion>();
        }

        public int IdOrganizacionNivelEduc { get; set; }
        public int IdOrganizacion { get; set; }
        public int IdHistoriaOrg { get; set; }
        public int IdNivelEducativo { get; set; }
        public bool? EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }

        public virtual Organizacion Id { get; set; } = null!;
        public virtual RefNivelEducativo IdNivelEducativoNavigation { get; set; } = null!;
        public virtual ICollection<Permutum> PermutumIdOrgNivelEducativoANavigations { get; set; }
        public virtual ICollection<Permutum> PermutumIdOrgNivelEducativoBNavigations { get; set; }
        public virtual ICollection<PlanUnidad> PlanUnidads { get; set; }
        public virtual ICollection<PlanillaNovedade> PlanillaNovedades { get; set; }
        public virtual ICollection<Plaza> Plazas { get; set; }
        public virtual ICollection<SolicitudLegajo> SolicitudLegajos { get; set; }
        public virtual ICollection<SolicitudPlaza> SolicitudPlazas { get; set; }
        public virtual ICollection<TableroOrganizacion> TableroOrganizacions { get; set; }
    }
}
