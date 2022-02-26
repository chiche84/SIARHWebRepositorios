using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    /// <summary>
    /// Turnos en los que la organización desarrolla sus actividades. Ejemplo Escuela con turno mañana y tarde
    /// </summary>
    public partial class OrganizacionTurno
    {
        public OrganizacionTurno()
        {
            DivisionAcrears = new HashSet<DivisionAcrear>();
            Divisions = new HashSet<Division>();
            Plazas = new HashSet<Plaza>();
            SolicitudPlazaDetalles = new HashSet<SolicitudPlazaDetalle>();
            SolicitudPlazaSitExts = new HashSet<SolicitudPlazaSitExt>();
            TableroOrganizacions = new HashSet<TableroOrganizacion>();
        }

        /// <summary>
        /// Clave primaria, autoincrementable.Codigo identificador de la tabla Organizacion Turno.
        /// </summary>
        public int IdOrganizacionTurno { get; set; }
        /// <summary>
        /// Clave foranea de la tabla Organizacion
        /// </summary>
        public int IdOrganizacion { get; set; }
        public int IdHistoriaOrg { get; set; }
        /// <summary>
        /// Clave Foranea de la tabla Turno.
        /// </summary>
        public int IdTurno { get; set; }
        public bool? EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }

        public virtual Organizacion Id { get; set; } = null!;
        public virtual RefTurno IdTurnoNavigation { get; set; } = null!;
        public virtual ICollection<DivisionAcrear> DivisionAcrears { get; set; }
        public virtual ICollection<Division> Divisions { get; set; }
        public virtual ICollection<Plaza> Plazas { get; set; }
        public virtual ICollection<SolicitudPlazaDetalle> SolicitudPlazaDetalles { get; set; }
        public virtual ICollection<SolicitudPlazaSitExt> SolicitudPlazaSitExts { get; set; }
        public virtual ICollection<TableroOrganizacion> TableroOrganizacions { get; set; }
    }
}
