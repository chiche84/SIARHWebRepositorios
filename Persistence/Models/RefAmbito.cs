using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    /// <summary>
    /// Ambitos a los que puede pertenecer un aorganizacion.  Privado o publico
    /// </summary>
    public partial class RefAmbito
    {
        public RefAmbito()
        {
            Organizacions = new HashSet<Organizacion>();
        }

        /// <summary>
        /// Primary key
        /// </summary>
        public int IdAmbito { get; set; }
        /// <summary>
        /// Descriptivo del ambito al que pertenece la organizacion publica, privada, etc
        /// </summary>
        public string AmbitoDesc { get; set; } = null!;
        public bool? EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }

        public virtual ICollection<Organizacion> Organizacions { get; set; }
    }
}
