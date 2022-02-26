using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    /// <summary>
    /// SIAC. Registra modificaciones en el presupuesto
    /// 
    /// </summary>
    public partial class MovimientosPresupuesto
    {
        /// <summary>
        /// Identificador de movimiento de itmes de presupuesto
        /// </summary>
        public int IdMovimiento { get; set; }
        /// <summary>
        /// Identificador de itemes de presupuesto
        /// </summary>
        public int IdPresupuesto { get; set; }
        /// <summary>
        /// Fecha en la que se realiza el movimiento
        /// </summary>
        public DateTime Fecha { get; set; }
        /// <summary>
        /// Clave foranea. Identificador de Motivo de movimiento, puede ser, presupuesto anual, refuerzo, etc.
        /// </summary>
        public int IdMotivoMovimientoPres { get; set; }
        /// <summary>
        /// Descripción detallada del movimiento
        /// </summary>
        public string? Observacion { get; set; }
        /// <summary>
        /// Identificador del instrumento legal que avala el movimiento sobre el presupuesto
        /// </summary>
        public int? IdInstrumentoLegal { get; set; }
        /// <summary>
        /// cantidad que se le añade a la cantidad de cargos registrados al inicio del prespuesto del ejercicio actual
        /// </summary>
        public int Cantidad { get; set; }
        /// <summary>
        /// Campo para eliminación lógica. Valor 1= verdadero, 0=falso
        /// </summary>
        public bool? EstaActivo { get; set; }
        /// <summary>
        /// fecha en la que deja de estar activo el movimiento
        /// </summary>
        public DateTime? FechaEliminacion { get; set; }
    }
}
