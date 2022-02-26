using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    /// <summary>
    /// Situaciones extraordinarias. Ejemplo: afectacion; traslado transitorio; normal
    /// </summary>
    public partial class RefSituacionExtraordinarium
    {
        /// <summary>
        /// Clave primaria, autoincrementable. Identificador de Situacion extraordinaria
        /// </summary>
        public int IdSituacionExtraordinaria { get; set; }
        /// <summary>
        /// Descripcion de la situacion extraordinaria. Ejemplo: afectacion; traslado transitorio; normal
        /// </summary>
        public string SituacionExtraordinariaDesc { get; set; } = null!;
        /// <summary>
        /// Campo para eliminacion logica. Valor 0 es igual a falso, valor 1 es igual a verdadero
        /// </summary>
        public bool? EstaActivo { get; set; }
        /// <summary>
        /// Fecha en la que deja de estar activa la situacion extraordinaria
        /// </summary>
        public DateTime? FechaEliminacion { get; set; }
    }
}
