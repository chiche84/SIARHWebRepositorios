using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    /// <summary>
    /// Tipo de funcion, tiene como objetivo agrupar los cargos funcionales
    /// </summary>
    public partial class RefTipoFuncion
    {
        public RefTipoFuncion()
        {
            CargoFuncionals = new HashSet<CargoFuncional>();
        }

        /// <summary>
        /// Clave primaria, autoincrementable. Identificador de tipo de funcion o agrupamiento de funciones
        /// </summary>
        public int IdTipoFuncion { get; set; }
        /// <summary>
        /// Nombre del tipo de funcion o agrupamiento
        /// </summary>
        public string TipoFuncionDesc { get; set; } = null!;
        /// <summary>
        /// Campo para eliminación lógica. Valor 0 es igual a falso, valor 1 es igual a verdadero
        /// </summary>
        public bool? EstaActivo { get; set; }
        /// <summary>
        /// Fecha en la que deja de estar activo le tipo de funcion
        /// </summary>
        public DateTime? FechaEliminacion { get; set; }

        public virtual ICollection<CargoFuncional> CargoFuncionals { get; set; }
    }
}
