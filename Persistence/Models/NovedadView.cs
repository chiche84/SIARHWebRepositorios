using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class NovedadView
    {
        public int IdNovedad { get; set; }
        public int IdTableroPlaza { get; set; }
        public int IdTipoNovedad { get; set; }
        public int IdSubservicio { get; set; }
        public DateTime FechaNovedad { get; set; }
        public TimeSpan HoraDesde { get; set; }
        public TimeSpan HoraHasta { get; set; }
        public int? Duracion { get; set; }
        public bool EstaProcesado { get; set; }
        public bool EstaActivo { get; set; }
        public string TipoNovedadDesc { get; set; } = null!;
        public bool ConGoceHaber { get; set; }
        public int IdPlaza { get; set; }
        public string CargoSalarialDesc { get; set; } = null!;
        public string SituacionRevistaDesc { get; set; } = null!;
        public int? CantidadHs { get; set; }
        public string? Curso { get; set; }
        public string? DivisionDesc { get; set; }
        public int? IdTerminoLectivo { get; set; }
        public string Apellido { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public TimeSpan HoraDesdeTableroPlaza { get; set; }
        public TimeSpan HoraHastaTableroPlaza { get; set; }
        public int IdDiaSemana { get; set; }
        public string DiaDesc { get; set; } = null!;
        public int IdServicio { get; set; }
        public int IdPersona { get; set; }
        public int? IdOrganizacion { get; set; }
        public int? IdHistoriaOrg { get; set; }
    }
}
