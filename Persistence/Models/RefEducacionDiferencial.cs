using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class RefEducacionDiferencial
    {
        public RefEducacionDiferencial()
        {
            Plazas = new HashSet<Plaza>();
        }

        public int IdEducacionDiferencial { get; set; }
        public string? EducacionDiferencialDesc { get; set; }
        public decimal? Porcentaje { get; set; }
        public bool? EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }

        public virtual ICollection<Plaza> Plazas { get; set; }
    }
}
