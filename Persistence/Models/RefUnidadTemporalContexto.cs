using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    /// <summary>
    ///  Unidad temporales según  el contexto, ej.: en el año calendario, en el año de servicio, en el mes calendario, etc.
    /// </summary>
    public partial class RefUnidadTemporalContexto
    {
        public RefUnidadTemporalContexto()
        {
            Licencia = new HashSet<Licencium>();
        }

        /// <summary>
        /// Clave primaria, autoincrementable.Codigo identificador de la unidad temporal contexto.
        /// </summary>
        public int IdUnidadTemporalContexto { get; set; }
        /// <summary>
        /// Descripcion de la unidad temporal contexto, ej.: en el año calendario, en el año de servicio, en el mes calendario, etc.
        /// </summary>
        public string? UnidadTemporalContextoDesc { get; set; }
        public bool? EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }

        public virtual ICollection<Licencium> Licencia { get; set; }
    }
}
