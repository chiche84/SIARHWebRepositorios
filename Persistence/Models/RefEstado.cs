using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    /// <summary>
    /// Descripcion de estados en los que se puede encontrar un cuil. Por ejemplo: verificado, no valido
    /// </summary>
    public partial class RefEstado
    {
        /// <summary>
        /// Clave primaria, autoincrementable. Identificador de Estados Si o No
        /// </summary>
        public int IdEstado { get; set; }
        /// <summary>
        /// Estado del cuil. Ejemplo: Verificado, no verificado, no valido
        /// </summary>
        public string EstadoDesc { get; set; } = null!;
        public bool? EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }
    }
}
