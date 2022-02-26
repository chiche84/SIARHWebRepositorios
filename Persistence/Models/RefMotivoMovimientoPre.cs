using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    /// <summary>
    /// Motivos por el cual se modifica la cantidad de cargos presupuestados 
    /// </summary>
    public partial class RefMotivoMovimientoPre
    {
        /// <summary>
        /// Identificador de motivo del movimiento sobre el presupuesto
        /// </summary>
        public int IdMotivoMovimientoPres { get; set; }
        /// <summary>
        /// Motivo por el cual se raliza un movimiento (cambio en la cantidad de cargos presupuestados). Ejemplo: Refuerzo
        /// </summary>
        public string MotivoMovimientoDesc { get; set; } = null!;
        /// <summary>
        /// Campo para eliminación lógica. Valor 1=verdadero, 0= falso 
        /// </summary>
        public bool? EstaActivo { get; set; }
        /// <summary>
        /// Fecha en la que deja de estar activo el motivo de movimiento
        /// </summary>
        public DateTime? FechaEliminacion { get; set; }
    }
}
