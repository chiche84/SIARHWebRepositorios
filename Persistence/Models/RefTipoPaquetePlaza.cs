using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class RefTipoPaquetePlaza
    {
        public RefTipoPaquetePlaza()
        {
            PaquetePlazas = new HashSet<PaquetePlaza>();
        }

        /// <summary>
        /// Clave primaria, autoincrementable.Codigo identificador del tipo de paquete.
        /// </summary>
        public int IdTipoPaquetePlaza { get; set; }
        /// <summary>
        /// Describe el tipo de paquete.
        /// </summary>
        public string? TipoPaquetePlazaDesc { get; set; }
        public bool EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }

        public virtual ICollection<PaquetePlaza> PaquetePlazas { get; set; }
    }
}
