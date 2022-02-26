using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    /// <summary>
    /// Tipos de financiemientos. Ejemplo: provincial, nacional
    /// </summary>
    public partial class RefFinanciamiento
    {
        public RefFinanciamiento()
        {
            Plazas = new HashSet<Plaza>();
            ReqSolicitudPrimaria = new HashSet<ReqSolicitudPrimarium>();
            SolicitudPlazaDetalles = new HashSet<SolicitudPlazaDetalle>();
            SolicitudPlazaSitExts = new HashSet<SolicitudPlazaSitExt>();
        }

        /// <summary>
        /// Clave primaria, autoincrementable.Codigo identificador del financiamiento educativo.
        /// </summary>
        public int IdFinanciamiento { get; set; }
        /// <summary>
        /// Describe el tipo de financiamiento educativo. (Provincial, Nacional, etc.)
        /// </summary>
        public string FinanciamientoDesc { get; set; } = null!;
        /// <summary>
        /// Indica si esta activo
        /// </summary>
        public bool? EstaActivo { get; set; }
        /// <summary>
        /// Fecha que termina la vigencia del financiamiento
        /// </summary>
        public DateTime? FechaEliminacion { get; set; }

        public virtual ICollection<Plaza> Plazas { get; set; }
        public virtual ICollection<ReqSolicitudPrimarium> ReqSolicitudPrimaria { get; set; }
        public virtual ICollection<SolicitudPlazaDetalle> SolicitudPlazaDetalles { get; set; }
        public virtual ICollection<SolicitudPlazaSitExt> SolicitudPlazaSitExts { get; set; }
    }
}
