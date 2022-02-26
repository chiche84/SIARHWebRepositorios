using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class RefEjercicio
    {
        public RefEjercicio()
        {
            Calendarios = new HashSet<Calendario>();
            NumeracionSolicituds = new HashSet<NumeracionSolicitud>();
            Partida = new HashSet<Partidum>();
            RefFinalidadxEjers = new HashSet<RefFinalidadxEjer>();
            RefFuncionxEjers = new HashSet<RefFuncionxEjer>();
            RefUdeOxEjers = new HashSet<RefUdeOxEjer>();
            SolicitudLegajos = new HashSet<SolicitudLegajo>();
            SolicitudPlazas = new HashSet<SolicitudPlaza>();
            SolicitudTurnos = new HashSet<SolicitudTurno>();
            TableroOrganizacions = new HashSet<TableroOrganizacion>();
            TerminoLectivos = new HashSet<TerminoLectivo>();
        }

        public int IdEjercicio { get; set; }
        public string EjercicioDesc { get; set; } = null!;
        public bool? EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }
        public bool EsPredeterminado { get; set; }

        public virtual ICollection<Calendario> Calendarios { get; set; }
        public virtual ICollection<NumeracionSolicitud> NumeracionSolicituds { get; set; }
        public virtual ICollection<Partidum> Partida { get; set; }
        public virtual ICollection<RefFinalidadxEjer> RefFinalidadxEjers { get; set; }
        public virtual ICollection<RefFuncionxEjer> RefFuncionxEjers { get; set; }
        public virtual ICollection<RefUdeOxEjer> RefUdeOxEjers { get; set; }
        public virtual ICollection<SolicitudLegajo> SolicitudLegajos { get; set; }
        public virtual ICollection<SolicitudPlaza> SolicitudPlazas { get; set; }
        public virtual ICollection<SolicitudTurno> SolicitudTurnos { get; set; }
        public virtual ICollection<TableroOrganizacion> TableroOrganizacions { get; set; }
        public virtual ICollection<TerminoLectivo> TerminoLectivos { get; set; }
    }
}
