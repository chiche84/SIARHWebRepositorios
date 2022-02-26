using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    /// <summary>
    /// Relacion entre CargoSalarial y CargoFuncional. Funciones por Cargo salarial (categoria)
    /// </summary>
    public partial class CargoSalarialFuncional
    {
        public int IdSalarialFuncional { get; set; }
        /// <summary>
        /// Clave foranea de la tabla CargoSalarial. Identificador del cargo salarial.
        /// </summary>
        public int? IdCargoSalarial { get; set; }
        /// <summary>
        /// Clave foranea de la tabla CargoFuncional. Identificador del cargo funcional.
        /// </summary>
        public int IdCargoFuncional { get; set; }
        /// <summary>
        /// Campo para eliminación lógica. Valor 0 es igual a falso, valor 1 es igual a verdadero.
        /// </summary>
        public bool? EstaActivo { get; set; }
        /// <summary>
        /// Almacena la fecha de alta de la relacion entre el cargo funcional y el cargo salarial.
        /// </summary>
        public DateTime? FechaAlta { get; set; }
        /// <summary>
        /// Almacena la fecha de baja de la relacion entre el cargo funcional y el cargo salarial.
        /// </summary>
        public DateTime? FechaEliminacion { get; set; }

        public virtual CargoFuncional IdCargoFuncionalNavigation { get; set; } = null!;
        public virtual CargoSalarial? IdCargoSalarialNavigation { get; set; }
    }
}
