using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class RefTemporalidad
    {
        public RefTemporalidad()
        {
            Plazas = new HashSet<Plaza>();
            SolicitudPlazaDetalles = new HashSet<SolicitudPlazaDetalle>();
            SolicitudPlazaSitExts = new HashSet<SolicitudPlazaSitExt>();
        }

        public int IdTemporalidad { get; set; }
        public string TemporalidadDesc { get; set; } = null!;
        public bool? EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }

        public virtual ICollection<Plaza> Plazas { get; set; }
        public virtual ICollection<SolicitudPlazaDetalle> SolicitudPlazaDetalles { get; set; }
        public virtual ICollection<SolicitudPlazaSitExt> SolicitudPlazaSitExts { get; set; }
    }
}
