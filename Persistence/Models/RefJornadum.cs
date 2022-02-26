using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    /// <summary>
    /// Jornadas en las que se puede desempeñar una organizacion. Ejemplo: jornada completa, simple, etc.
    /// </summary>
    public partial class RefJornadum
    {
        public RefJornadum()
        {
            CargoSalarials = new HashSet<CargoSalarial>();
            Organizacions = new HashSet<Organizacion>();
            ReqSolicitudPrimaria = new HashSet<ReqSolicitudPrimarium>();
        }

        /// <summary>
        /// Clave primaria, autoincremental. Identificador de la jornada de la organizacion
        /// </summary>
        public int IdJornada { get; set; }
        /// <summary>
        /// Jornada de la organizacion. Ejemplo jornada simple, completa
        /// </summary>
        public string JornadaDesc { get; set; } = null!;
        /// <summary>
        /// Nemotécnico de la jornada. Ejemplo JS, JC, AA
        /// </summary>
        public string Nemotecnico { get; set; } = null!;
        /// <summary>
        /// Indica si esta activo (1) o no (0) el motivo de Alta
        /// </summary>
        public bool? EstaActivo { get; set; }
        /// <summary>
        /// Fecha en la que deja de estar activa la jornada
        /// </summary>
        public DateTime? FechaEliminacion { get; set; }

        public virtual ICollection<CargoSalarial> CargoSalarials { get; set; }
        public virtual ICollection<Organizacion> Organizacions { get; set; }
        public virtual ICollection<ReqSolicitudPrimarium> ReqSolicitudPrimaria { get; set; }
    }
}
