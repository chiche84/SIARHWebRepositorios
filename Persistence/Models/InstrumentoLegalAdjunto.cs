using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class InstrumentoLegalAdjunto
    {
        /// <summary>
        /// Campo clave. Identificador de archivo adjunto.
        /// </summary>
        public int IdAdjunto { get; set; }
        /// <summary>
        /// Nombre del archivo.
        /// </summary>
        public string NombreArchivo { get; set; } = null!;
        /// <summary>
        /// Identificador global unico de archivo
        /// </summary>
        public string GuidArchivo { get; set; } = null!;
        /// <summary>
        /// Clave foranea. Identificador del instrumento legal al que se encuentra asociado el archivo.
        /// </summary>
        public int? IdInstrumentoLegal { get; set; }
        /// <summary>
        /// Usuario responsable de subida de archivo
        /// </summary>
        public string? Usuario { get; set; }
        /// <summary>
        /// Fecha de subida de archivo
        /// </summary>
        public DateTime? Fecha { get; set; }
        public bool? EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }

        public virtual InstrumentoLegal? IdInstrumentoLegalNavigation { get; set; }
    }
}
