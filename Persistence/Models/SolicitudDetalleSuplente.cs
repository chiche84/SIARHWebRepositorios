using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class SolicitudDetalleSuplente
    {
        public int IdSolicitudDetalle { get; set; }
        public int? IdSolicitudDetalleLicenciaOrigen { get; set; }
        public int? IdSubServicioOrigen { get; set; }
        public DateTime FechaDesde { get; set; }
        public DateTime? FechaHasta { get; set; }
        public int IdPlaza { get; set; }
        public int? IdSituacionRevista { get; set; }
        public int? IdTerminoLectivo { get; set; }
        public int? IdTipoServicio { get; set; }
        public int? IdTituloHabilitante { get; set; }
        public bool EstaFrenteAlumno { get; set; }
        public int IdPlazaHistoria { get; set; }
        public bool AdmiteSuplente { get; set; }

        public virtual Plaza IdPlazaNavigation { get; set; } = null!;
        public virtual RefSituacionRevistum? IdSituacionRevistaNavigation { get; set; }
        public virtual SolicitudDetalle IdSolicitudDetalleNavigation { get; set; } = null!;
        public virtual TerminoLectivo? IdTerminoLectivoNavigation { get; set; }
        public virtual RefTipoServicio? IdTipoServicioNavigation { get; set; }
        public virtual RefTituloHabilitante? IdTituloHabilitanteNavigation { get; set; }
    }
}
