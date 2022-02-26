using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    /// <summary>
    /// Relacion entre plan de estudio y la organizacion. Una organización puede tener varios planes de estudio
    /// </summary>
    public partial class PlanUnidad
    {
        public PlanUnidad()
        {
            DivisionAcrears = new HashSet<DivisionAcrear>();
            Divisions = new HashSet<Division>();
            PlazaHistoria = new HashSet<PlazaHistorium>();
            ReqSolicitudPrimaria = new HashSet<ReqSolicitudPrimarium>();
            SolicitudPlazaDetalles = new HashSet<SolicitudPlazaDetalle>();
            SolicitudPlazaSitExts = new HashSet<SolicitudPlazaSitExt>();
        }

        /// <summary>
        /// Clave primaria, autoincrementable. Identificador de plan unidad
        /// </summary>
        public int IdPlanUnidad { get; set; }
        public int? IdPlanEstudioCohorte { get; set; }
        /// <summary>
        /// Clave foranea. Identificador del nivel de escolaridad relacionado
        /// </summary>
        public int IdOrganizacionNivelEduc { get; set; }
        /// <summary>
        /// Campo para eliminación logica
        /// </summary>
        public bool? EstaActivo { get; set; }
        /// <summary>
        /// Fecha en la que deja de estar activa la relación entre organización, plan de estudio y nivel de escolaridad
        /// </summary>
        public DateTime? FechaEliminacion { get; set; }

        public virtual OrganizacionNivelEducativo IdOrganizacionNivelEducNavigation { get; set; } = null!;
        public virtual PlanEstudioCohorte? IdPlanEstudioCohorteNavigation { get; set; }
        public virtual ICollection<DivisionAcrear> DivisionAcrears { get; set; }
        public virtual ICollection<Division> Divisions { get; set; }
        public virtual ICollection<PlazaHistorium> PlazaHistoria { get; set; }
        public virtual ICollection<ReqSolicitudPrimarium> ReqSolicitudPrimaria { get; set; }
        public virtual ICollection<SolicitudPlazaDetalle> SolicitudPlazaDetalles { get; set; }
        public virtual ICollection<SolicitudPlazaSitExt> SolicitudPlazaSitExts { get; set; }
    }
}
