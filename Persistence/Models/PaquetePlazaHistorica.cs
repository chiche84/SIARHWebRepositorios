using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class PaquetePlazaHistorica
    {
        /// <summary>
        /// Primary key
        /// </summary>
        public int IdPaquetePlazaHistorica { get; set; }
        public int IdPaquete { get; set; }
        public int IdPlazaCabecera { get; set; }
        public int IdTipoPaquetePlaza { get; set; }
        public DateTime? FechaAlta { get; set; }
        public DateTime? FechaBaja { get; set; }
        /// <summary>
        /// Link to RefMotivoBaja table
        /// </summary>
        public int IdMotivoBaja { get; set; }
        public bool? EstaActivo { get; set; }

        public virtual RefMotivoBaja IdMotivoBajaNavigation { get; set; } = null!;
    }
}
