using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    /// <summary>
    /// Ttipos de regimenes laborales. Ejemplo:  Docente, No Docente, Contratado Provincial
    /// </summary>
    public partial class RefRegimenLaboral
    {
        public RefRegimenLaboral()
        {
            Plazas = new HashSet<Plaza>();
            ReqSolicitudPrimaria = new HashSet<ReqSolicitudPrimarium>();
            SolicitudPlazaDetalles = new HashSet<SolicitudPlazaDetalle>();
            SolicitudPlazaSitExts = new HashSet<SolicitudPlazaSitExt>();
        }

        /// <summary>
        /// Clave primaria, autoincrementable. Identificador de regimen laboral
        /// </summary>
        public int IdRegimenLaboral { get; set; }
        /// <summary>
        /// Describe el tipo de regimen laboral Docente, No Docente, Contratado Provincial
        /// </summary>
        public string RegimenLaboralDesc { get; set; } = null!;
        public bool? EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }

        public virtual ICollection<Plaza> Plazas { get; set; }
        public virtual ICollection<ReqSolicitudPrimarium> ReqSolicitudPrimaria { get; set; }
        public virtual ICollection<SolicitudPlazaDetalle> SolicitudPlazaDetalles { get; set; }
        public virtual ICollection<SolicitudPlazaSitExt> SolicitudPlazaSitExts { get; set; }
    }
}
