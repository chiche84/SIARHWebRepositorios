using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    /// <summary>
    /// Situacion en la que puede estar trabajando un docente. Ejemplo: titular; provisional, suplente
    /// </summary>
    public partial class RefSituacionRevistum
    {
        public RefSituacionRevistum()
        {
            LicenciaPorSituacionDeRevista = new HashSet<LicenciaPorSituacionDeRevistum>();
            Servicios = new HashSet<Servicio>();
            SolicitudDetalleCambioSrs = new HashSet<SolicitudDetalleCambioSr>();
            SolicitudDetalleDesignacions = new HashSet<SolicitudDetalleDesignacion>();
            SolicitudDetalleSuplentes = new HashSet<SolicitudDetalleSuplente>();
            SolicitudPlazaDesignacions = new HashSet<SolicitudPlazaDesignacion>();
        }

        /// <summary>
        /// Clave primaria, autoincrementable. Identificador de situacion en la que puede estar trabajando un docente
        /// </summary>
        public int IdSituacionRevista { get; set; }
        /// <summary>
        /// Descripcion de la situacion de revista. Ejemplo: titular; provisional, suplente
        /// </summary>
        public string SituacionRevistaDesc { get; set; } = null!;
        public bool EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }

        public virtual ICollection<LicenciaPorSituacionDeRevistum> LicenciaPorSituacionDeRevista { get; set; }
        public virtual ICollection<Servicio> Servicios { get; set; }
        public virtual ICollection<SolicitudDetalleCambioSr> SolicitudDetalleCambioSrs { get; set; }
        public virtual ICollection<SolicitudDetalleDesignacion> SolicitudDetalleDesignacions { get; set; }
        public virtual ICollection<SolicitudDetalleSuplente> SolicitudDetalleSuplentes { get; set; }
        public virtual ICollection<SolicitudPlazaDesignacion> SolicitudPlazaDesignacions { get; set; }
    }
}
