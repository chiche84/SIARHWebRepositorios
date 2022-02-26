using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    /// <summary>
    /// Agrupa finalidad, función, escalafon
    /// 
    /// </summary>
    public partial class Partidum
    {
        public Partidum()
        {
            PlazaPresupuestos = new HashSet<PlazaPresupuesto>();
        }

        public int IdPartida { get; set; }
        public int IdCuenta { get; set; }
        public string Partida { get; set; } = null!;
        public decimal? ImportePartida { get; set; }
        /// <summary>
        /// Identifica el Escalafon de la Partida
        /// </summary>
        public int IdUdeOxEjer { get; set; }
        /// <summary>
        /// Identifica la Finalidad de la Partida
        /// </summary>
        public int IdFinalidadxEjer { get; set; }
        /// <summary>
        /// Identifica la Funcion de la Partida
        /// </summary>
        public int IdFuncionxEjer { get; set; }
        public int IdEjercicio { get; set; }
        public short? CodigoPartida { get; set; }
        public bool? EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }

        public virtual RefCuenta IdCuentaNavigation { get; set; } = null!;
        public virtual RefEjercicio IdEjercicioNavigation { get; set; } = null!;
        public virtual RefFinalidadxEjer IdFinalidadxEjerNavigation { get; set; } = null!;
        public virtual RefFuncionxEjer IdFuncionxEjerNavigation { get; set; } = null!;
        public virtual RefUdeOxEjer IdUdeOxEjerNavigation { get; set; } = null!;
        public virtual ICollection<PlazaPresupuesto> PlazaPresupuestos { get; set; }
    }
}
