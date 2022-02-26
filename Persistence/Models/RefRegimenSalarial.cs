using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    /// <summary>
    /// El regimen salarial puede ser de tipo horas o cargo, etc.
    /// </summary>
    public partial class RefRegimenSalarial
    {
        public RefRegimenSalarial()
        {
            Plazas = new HashSet<Plaza>();
            ReqSolicitudPrimaria = new HashSet<ReqSolicitudPrimarium>();
            SolicitudPlazaDetalles = new HashSet<SolicitudPlazaDetalle>();
            SolicitudPlazaSitExts = new HashSet<SolicitudPlazaSitExt>();
        }

        /// <summary>
        /// Clave primaria, autoincrementable. Identificador del regimen salarial
        /// </summary>
        public int IdRegimenSalarial { get; set; }
        /// <summary>
        /// Indica si la Plaza es de tipo horas o bien un cargo
        /// </summary>
        public string RegimenSalarialDesc { get; set; } = null!;
        public bool? EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }

        public virtual ICollection<Plaza> Plazas { get; set; }
        public virtual ICollection<ReqSolicitudPrimarium> ReqSolicitudPrimaria { get; set; }
        public virtual ICollection<SolicitudPlazaDetalle> SolicitudPlazaDetalles { get; set; }
        public virtual ICollection<SolicitudPlazaSitExt> SolicitudPlazaSitExts { get; set; }
    }
}
