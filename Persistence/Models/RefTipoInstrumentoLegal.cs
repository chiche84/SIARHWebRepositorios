using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    /// <summary>
    /// Tipos de instrumento legales. Ejemplo: resolucion, norma, etc.
    /// </summary>
    public partial class RefTipoInstrumentoLegal
    {
        public RefTipoInstrumentoLegal()
        {
            InstrumentoLegals = new HashSet<InstrumentoLegal>();
        }

        /// <summary>
        /// Clave primaria, autoincrementable. Identificador de tipo de instrumento legal
        /// </summary>
        public int IdTipoInstrumentoLegal { get; set; }
        /// <summary>
        /// Nombre del tipo de instrumento legal
        /// </summary>
        public string? TipoInstrumentoLegalDesc { get; set; }
        /// <summary>
        /// Campo de eliminación logica
        /// </summary>
        public bool? EstaActivo { get; set; }
        /// <summary>
        /// Fecha en la que deja de estar activo el tipo de instrumento legal
        /// </summary>
        public DateTime? FechaEliminacion { get; set; }

        public virtual ICollection<InstrumentoLegal> InstrumentoLegals { get; set; }
    }
}
