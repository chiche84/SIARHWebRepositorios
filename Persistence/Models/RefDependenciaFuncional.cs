using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class RefDependenciaFuncional
    {
        public RefDependenciaFuncional()
        {
            Organizacions = new HashSet<Organizacion>();
        }

        public int IdDependenciaFuncional { get; set; }
        public string DependenciaFuncionalDesc { get; set; } = null!;
        public bool? EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }

        public virtual ICollection<Organizacion> Organizacions { get; set; }
    }
}
