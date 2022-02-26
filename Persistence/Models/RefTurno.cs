using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    /// <summary>
    /// Turnos en los que se puede desempeñar una organización
    /// </summary>
    public partial class RefTurno
    {
        public RefTurno()
        {
            OrganizacionTurnos = new HashSet<OrganizacionTurno>();
            RefTipoTableros = new HashSet<RefTipoTablero>();
        }

        /// <summary>
        /// Clave primaria, autoincrementable. Identificador de turno
        /// </summary>
        public int IdTurno { get; set; }
        /// <summary>
        /// Descripción del turno. Ejemplo: mañana, mañana-tarde
        /// </summary>
        public string TurnoDesc { get; set; } = null!;
        public bool? EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }

        public virtual ICollection<OrganizacionTurno> OrganizacionTurnos { get; set; }
        public virtual ICollection<RefTipoTablero> RefTipoTableros { get; set; }
    }
}
