using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    /// <summary>
    /// Descripción del tipo de documento. Ejemplo: Documento Nacional de Identidad, Libreta cívica
    /// </summary>
    public partial class RefTipoDocumento
    {
        public RefTipoDocumento()
        {
            Familia = new HashSet<Familium>();
            Personas = new HashSet<Persona>();
            SolicitudDetalleDesignacions = new HashSet<SolicitudDetalleDesignacion>();
            SolicitudPlazaDesignacions = new HashSet<SolicitudPlazaDesignacion>();
        }

        /// <summary>
        /// Clave primaria, autoincrementable. Identificador de tipo de documento
        /// </summary>
        public int IdTipoDocumento { get; set; }
        /// <summary>
        /// Nombre del tipo de documento. Ejemplo: DNI, LC
        /// </summary>
        public string TipoDocumentoDesc { get; set; } = null!;
        /// <summary>
        /// Descripción del tipo de documento. Ejemplo: Documento Nacional de Identidad, Libreta cívica
        /// </summary>
        public string? Descripcion { get; set; }
        /// <summary>
        /// Campo para eliminación lógica
        /// </summary>
        public bool? EstaActivo { get; set; }
        /// <summary>
        /// Fecha en la que deja de estar activo el tipo de documento
        /// </summary>
        public DateTime? FechaEliminacion { get; set; }

        public virtual ICollection<Familium> Familia { get; set; }
        public virtual ICollection<Persona> Personas { get; set; }
        public virtual ICollection<SolicitudDetalleDesignacion> SolicitudDetalleDesignacions { get; set; }
        public virtual ICollection<SolicitudPlazaDesignacion> SolicitudPlazaDesignacions { get; set; }
    }
}
