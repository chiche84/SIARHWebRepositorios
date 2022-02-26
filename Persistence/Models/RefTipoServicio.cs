using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    /// <summary>
    /// Tipos de servicio. Ejemplo: De base, sujeto a licencia, etc.
    /// </summary>
    public partial class RefTipoServicio
    {
        public RefTipoServicio()
        {
            SolicitudDetalleDesignacions = new HashSet<SolicitudDetalleDesignacion>();
            SolicitudDetalleSuplentes = new HashSet<SolicitudDetalleSuplente>();
        }

        /// <summary>
        /// Clave primaria, autoincrementable. Identificador de tipo de servicio
        /// </summary>
        public int IdTipoServicio { get; set; }
        /// <summary>
        /// Descripción del tipo de servicio. Ejemplo: De base, Sujeto a licencia, Servicio componente
        /// </summary>
        public string? TipoServicioDesc { get; set; }
        /// <summary>
        /// Campo para eliminación lógica. Valor 0 es igual a falso, valor 1 es igual a verdadero
        /// </summary>
        public bool? EstaActivo { get; set; }
        /// <summary>
        /// Fecha en la que deja de estar activo el tipo de servicio
        /// </summary>
        public DateTime? FechaEliminacion { get; set; }

        public virtual ICollection<SolicitudDetalleDesignacion> SolicitudDetalleDesignacions { get; set; }
        public virtual ICollection<SolicitudDetalleSuplente> SolicitudDetalleSuplentes { get; set; }
    }
}
