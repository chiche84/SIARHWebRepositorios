using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class TerminoLectivoRegistro
    {
        public int IdTerminoLectivoRegistro { get; set; }
        public int IdTerminoLectivoActualizacion { get; set; }
        public int IdTerminoLectivo { get; set; }
        public DateTime FechaInicioActual { get; set; }
        public DateTime FechaInicioNueva { get; set; }
        public string Entidad { get; set; } = null!;
        public int IdEntidad { get; set; }
        public bool Procesado { get; set; }
        public string? Mensaje { get; set; }
        public bool? EstaActivo { get; set; }

        public virtual TerminoLectivo IdTerminoLectivoNavigation { get; set; } = null!;
    }
}
