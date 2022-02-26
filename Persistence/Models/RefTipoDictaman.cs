using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class RefTipoDictaman
    {
        public RefTipoDictaman()
        {
            PersonaSumarioDictamen = new HashSet<PersonaSumarioDictaman>();
        }

        public int IdTipoDictamen { get; set; }
        public string TipoDictamenDesc { get; set; } = null!;
        public bool? EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }

        public virtual ICollection<PersonaSumarioDictaman> PersonaSumarioDictamen { get; set; }
    }
}
