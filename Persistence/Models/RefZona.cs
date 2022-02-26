using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    /// <summary>
    /// Zonas educativas. Ejemplo Zona 0 (desfavorable)
    /// </summary>
    public partial class RefZona
    {
        public RefZona()
        {
            Organizacions = new HashSet<Organizacion>();
        }

        /// <summary>
        /// Clave primaria, autoincrementable. Identificador de zona 
        /// </summary>
        public int IdZona { get; set; }
        /// <summary>
        /// Descripcion de la zona. Ejemplo: Zona 0; zona 1
        /// </summary>
        public string? ZonaDesc { get; set; }
        /// <summary>
        /// porcentaje que corresponde a la zona, para liquidacion
        /// </summary>
        public int? Porcentaje { get; set; }
        /// <summary>
        /// Clave para eliminación lógica. Valor 0 es igual a falso, valor 1 es igual a verdadero
        /// </summary>
        public bool? EstaActivo { get; set; }
        /// <summary>
        /// Fecha en la que deja de estar activa la zona
        /// </summary>
        public DateTime? FechaEliminacion { get; set; }

        public virtual ICollection<Organizacion> Organizacions { get; set; }
    }
}
