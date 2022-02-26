using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    /// <summary>
    /// Plazas agrupadas por paquetes
    /// </summary>
    public partial class PaquetePlaza
    {
        public PaquetePlaza()
        {
            Plazas = new HashSet<Plaza>();
        }

        /// <summary>
        /// Clave primaria, autoincrementable.Codigo identificador de un paquete de plazas.
        /// </summary>
        public int IdPaquete { get; set; }
        /// <summary>
        /// Clave foranea, identifica a la plaza cabecera del paquete.
        /// </summary>
        public int IdPlazaCabecera { get; set; }
        /// <summary>
        /// Clave foranea, identifica el tipo de paquete.
        /// </summary>
        public int IdTipoPaquetePlaza { get; set; }
        /// <summary>
        /// Indica si esta activo (1) o no (0) el motivo de Alta
        /// </summary>
        public bool? EstaActivo { get; set; }
        /// <summary>
        /// Fecha en la que deja de estar activo el motivo de baja
        /// </summary>
        public DateTime? FechaEliminacion { get; set; }

        public virtual Plaza IdPlazaCabeceraNavigation { get; set; } = null!;
        public virtual RefTipoPaquetePlaza IdTipoPaquetePlazaNavigation { get; set; } = null!;
        public virtual ICollection<Plaza> Plazas { get; set; }
    }
}
