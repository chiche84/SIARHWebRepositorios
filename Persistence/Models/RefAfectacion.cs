using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    /// <summary>
    /// Afectaciones presupuestarias de plazas. Intra o Extra Presupuestario
    /// </summary>
    public partial class RefAfectacion
    {
        public RefAfectacion()
        {
            PlazaPresupuestos = new HashSet<PlazaPresupuesto>();
            Plazas = new HashSet<Plaza>();
            SolicitudPlazaDetalles = new HashSet<SolicitudPlazaDetalle>();
            SolicitudPlazaSitExts = new HashSet<SolicitudPlazaSitExt>();
        }

        public int IdAfectacion { get; set; }
        /// <summary>
        /// Afectacion del cargo Ej: Intra o Extra presupuestario
        /// </summary>
        public string AfectacionDesc { get; set; } = null!;
        public bool? EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }

        public virtual ICollection<PlazaPresupuesto> PlazaPresupuestos { get; set; }
        public virtual ICollection<Plaza> Plazas { get; set; }
        public virtual ICollection<SolicitudPlazaDetalle> SolicitudPlazaDetalles { get; set; }
        public virtual ICollection<SolicitudPlazaSitExt> SolicitudPlazaSitExts { get; set; }
    }
}
