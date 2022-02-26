using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class RefSubvencion
    {
        public RefSubvencion()
        {
            Organizacions = new HashSet<Organizacion>();
        }

        /// <summary>
        /// Clave primaria. Identificador de tipo de subvencion
        /// </summary>
        public int IdSubvencion { get; set; }
        /// <summary>
        /// Descripcion de tipo de subvención. Ej: Con subvencion- privada, Coon subvencion - gestion social, Sin subvebcion 
        /// </summary>
        public string SubvencionDesc { get; set; } = null!;
        /// <summary>
        /// Campo para eliminacion logica. Valor 0 es igual a falso, valor 1 es igual a verdadero
        /// </summary>
        public bool? EstaActivo { get; set; }
        /// <summary>
        /// Fecha de eliminacion lógica
        /// </summary>
        public DateTime? FechaEliminacion { get; set; }

        public virtual ICollection<Organizacion> Organizacions { get; set; }
    }
}
