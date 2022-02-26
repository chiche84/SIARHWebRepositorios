using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class RefCargoTipo
    {
        /// <summary>
        /// Código identificador de tipo de cargo
        /// </summary>
        public byte IdTipoCargo { get; set; }
        /// <summary>
        /// Tipo de cargo. Ejemplo: horas, cargo, etc.
        /// </summary>
        public string TipoCargoDesc { get; set; } = null!;
        /// <summary>
        /// Observaciones acerca del tipo de cargo
        /// </summary>
        public string? Observacion { get; set; }
        /// <summary>
        /// Campo para eliminación lógica
        /// </summary>
        public bool? EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }
    }
}
