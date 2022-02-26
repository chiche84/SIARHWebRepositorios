using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class SolicitudPlazaDesignacion
    {
        public int IdSolicitudPlazaDesignacion { get; set; }
        public int IdSolicitudPlazaDetalle { get; set; }
        public int? IdPersona { get; set; }
        public int? IdTipoDocumento { get; set; }
        public int? Dni { get; set; }
        public string? Cuil { get; set; }
        public string? Apellido { get; set; }
        public string? Nombre { get; set; }
        public int? IdSexo { get; set; }
        public int? IdInstrumentoLegalDesig { get; set; }
        public int? IdSituacionRevista { get; set; }
        public bool? EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }

        public virtual InstrumentoLegal? IdInstrumentoLegalDesigNavigation { get; set; }
        public virtual Persona? IdPersonaNavigation { get; set; }
        public virtual RefSexo? IdSexoNavigation { get; set; }
        public virtual RefSituacionRevistum? IdSituacionRevistaNavigation { get; set; }
        public virtual SolicitudPlazaDetalle IdSolicitudPlazaDetalleNavigation { get; set; } = null!;
        public virtual RefTipoDocumento? IdTipoDocumentoNavigation { get; set; }
    }
}
