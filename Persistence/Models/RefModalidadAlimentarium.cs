using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class RefModalidadAlimentarium
    {
        public RefModalidadAlimentarium()
        {
            Organizacions = new HashSet<Organizacion>();
        }

        /// <summary>
        /// Clave primaria, identificador de modalidad alimentaria
        /// </summary>
        public int IdModAlimentaria { get; set; }
        /// <summary>
        /// Descripción de modalidad alimentaria
        /// </summary>
        public string ModAlimentariaDesc { get; set; } = null!;
        /// <summary>
        /// Campo para eliminacion logica. Valor 0 es igual a falso, valor 1 es igual a verdadero
        /// </summary>
        public bool? EstaActivo { get; set; }
        /// <summary>
        /// Fecha de aliminación lógica
        /// </summary>
        public DateTime? FechaEliminacion { get; set; }

        public virtual ICollection<Organizacion> Organizacions { get; set; }
    }
}
