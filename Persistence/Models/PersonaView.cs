using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class PersonaView
    {
        public int IdPersona { get; set; }
        public string Nombre { get; set; } = null!;
        public string Apellido { get; set; } = null!;
        public int? IdSexo { get; set; }
        public string? Cuil { get; set; }
        public int? Documento { get; set; }
        public int? IdTipoDocumento { get; set; }
        public bool EstaActivo { get; set; }
        public bool? EstaVivo { get; set; }
        public string TipoDocumentoDesc { get; set; } = null!;
        public string SexoDesc { get; set; } = null!;
    }
}
