using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class RefTipoAsignaturaPrevium
    {
        /// <summary>
        /// Primary key
        /// </summary>
        public int IdTipoAsignaturaPrevia { get; set; }
        public string TipoAsignaturaPreviaDesc { get; set; } = null!;
        public string MNemo { get; set; } = null!;
        public bool? EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }
    }
}
