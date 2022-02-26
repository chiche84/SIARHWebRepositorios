using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class Division
    {
        public Division()
        {
            GrupoDivisionIdDivisionCabeceraNavigations = new HashSet<GrupoDivision>();
            GrupoDivisionIdDivisionNavigations = new HashSet<GrupoDivision>();
            Plazas = new HashSet<Plaza>();
            ReqSolicitudPrimaria = new HashSet<ReqSolicitudPrimarium>();
            SolicitudPlazaDetalles = new HashSet<SolicitudPlazaDetalle>();
            SolicitudPlazaSitExts = new HashSet<SolicitudPlazaSitExt>();
        }

        /// <summary>
        /// Clave primaria, autoincrementable.Codigo identificador de division.
        /// </summary>
        public int IdDivision { get; set; }
        /// <summary>
        /// Clave foranea de Plan Unidad
        /// </summary>
        public int IdPlanUnidad { get; set; }
        /// <summary>
        /// Clave foranea de la tabla organizacion-turno
        /// </summary>
        public int IdOrganizacionTurno { get; set; }
        /// <summary>
        /// Curso, año o nombre de grupo. Ejemplo: 1, 2, Educacion fisica mujeres, etc.
        /// </summary>
        public string? Curso { get; set; }
        /// <summary>
        /// Descripcion de la division. Ejemplo: A, B, etc.
        /// </summary>
        public string? DivisionDesc { get; set; }
        /// <summary>
        /// Identifica si el registro esta activo.
        /// </summary>
        public bool? EstaActivo { get; set; }
        /// <summary>
        /// Almacena la fecha de alta de la division.
        /// </summary>
        public DateTime FechaAlta { get; set; }
        /// <summary>
        /// Almacena la fecha de baja de la division.
        /// </summary>
        public DateTime? FechaEliminacion { get; set; }
        public bool EsGrupo { get; set; }

        public virtual OrganizacionTurno IdOrganizacionTurnoNavigation { get; set; } = null!;
        public virtual PlanUnidad IdPlanUnidadNavigation { get; set; } = null!;
        public virtual ICollection<GrupoDivision> GrupoDivisionIdDivisionCabeceraNavigations { get; set; }
        public virtual ICollection<GrupoDivision> GrupoDivisionIdDivisionNavigations { get; set; }
        public virtual ICollection<Plaza> Plazas { get; set; }
        public virtual ICollection<ReqSolicitudPrimarium> ReqSolicitudPrimaria { get; set; }
        public virtual ICollection<SolicitudPlazaDetalle> SolicitudPlazaDetalles { get; set; }
        public virtual ICollection<SolicitudPlazaSitExt> SolicitudPlazaSitExts { get; set; }
    }
}
