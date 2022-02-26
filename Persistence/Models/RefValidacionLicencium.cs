using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class RefValidacionLicencium
    {
        public RefValidacionLicencium()
        {
            LicenciaValidacionLicencia = new HashSet<LicenciaValidacionLicencium>();
        }

        public int IdValidacionLicencia { get; set; }
        public string? ValidacionLicenciaNombre { get; set; }
        public bool? EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }

        public virtual ICollection<LicenciaValidacionLicencium> LicenciaValidacionLicencia { get; set; }
    }
}
