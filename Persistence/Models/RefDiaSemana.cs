using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class RefDiaSemana
    {
        public RefDiaSemana()
        {
            TableroBases = new HashSet<TableroBase>();
            TableroOrganizacionDetalles = new HashSet<TableroOrganizacionDetalle>();
        }

        public int IdDiaSemana { get; set; }
        public string DiaDesc { get; set; } = null!;
        public string Mnemo { get; set; } = null!;

        public virtual ICollection<TableroBase> TableroBases { get; set; }
        public virtual ICollection<TableroOrganizacionDetalle> TableroOrganizacionDetalles { get; set; }
    }
}
