using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class PersonaSumarioInstLegal
    {
        public int IdPersonaSumarioIl { get; set; }
        public int IdPersonaSumario { get; set; }
        public int? IdInstrumentoLegal { get; set; }
        public int? IdExpediente { get; set; }
        public int IdSumarioEtapa { get; set; }
        public bool EsRecurso { get; set; }
        public bool? EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }

        public virtual InstrumentoLegal? IdInstrumentoLegalNavigation { get; set; }
        public virtual PersonaSumario IdPersonaSumarioNavigation { get; set; } = null!;
        public virtual RefSumarioEtapa IdSumarioEtapaNavigation { get; set; } = null!;
    }
}
