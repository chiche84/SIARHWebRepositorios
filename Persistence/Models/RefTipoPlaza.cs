using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class RefTipoPlaza
    {
        public RefTipoPlaza()
        {
            SolicitudPlazaDetalles = new HashSet<SolicitudPlazaDetalle>();
            SolicitudPlazaSitExts = new HashSet<SolicitudPlazaSitExt>();
        }

        /// <summary>
        /// Clave primaria, autoincremental. Identificador de tipo de solicitud
        /// </summary>
        public int IdTipoPlaza { get; set; }
        /// <summary>
        /// Tipo de solicitud: ordinaria, extraordinaria
        /// </summary>
        public string TipoPlazaDesc { get; set; } = null!;
        /// <summary>
        /// Campo para eliminacion logica
        /// </summary>
        public bool? EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }

        public virtual ICollection<SolicitudPlazaDetalle> SolicitudPlazaDetalles { get; set; }
        public virtual ICollection<SolicitudPlazaSitExt> SolicitudPlazaSitExts { get; set; }
    }
}
