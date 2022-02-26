using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class LicenciaValidacionLicencium
    {
        public int IdLicenciaValidacionLicencia { get; set; }
        public int IdLicencia { get; set; }
        public int IdValidacionLicencia { get; set; }
        public bool? EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }

        public virtual Licencium IdLicenciaNavigation { get; set; } = null!;
        public virtual RefValidacionLicencium IdValidacionLicenciaNavigation { get; set; } = null!;
    }
}
