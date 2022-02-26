using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    /// <summary>
    /// Motivos por los cuales se puede dar de baja un servicio o subservicio. Ejemplo: Designacion termino, renuncia,etc.
    /// </summary>
    public partial class RefMotivoBaja
    {
        public RefMotivoBaja()
        {
            PaquetePlazaHistoricas = new HashSet<PaquetePlazaHistorica>();
            Plazas = new HashSet<Plaza>();
        }

        /// <summary>
        /// Autoincremental
        /// </summary>
        public int IdMotivoBaja { get; set; }
        /// <summary>
        /// Especifica el motivo de baja
        /// </summary>
        public string MotivoBajaDesc { get; set; } = null!;
        /// <summary>
        /// Indica si esta activo (1) o no (0) el motivo de baja
        /// </summary>
        public bool? EstaActivo { get; set; }
        /// <summary>
        /// Fecha en la que deja de estar activo el motivo de baja
        /// </summary>
        public DateTime? FechaEliminacion { get; set; }

        public virtual ICollection<PaquetePlazaHistorica> PaquetePlazaHistoricas { get; set; }
        public virtual ICollection<Plaza> Plazas { get; set; }
    }
}
