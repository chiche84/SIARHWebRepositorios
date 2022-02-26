using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    /// <summary>
    /// Adicionales para liquidacion. Ejemplo adicionales por mayor horario, por mayor responsabilidad, etc.
    /// </summary>
    public partial class RefAdicional
    {
        public RefAdicional()
        {
            Presupuestos = new HashSet<Presupuesto>();
            SubServicios = new HashSet<SubServicio>();
        }

        /// <summary>
        /// Clave primaria, autoincrementable. Identificador de Adicional
        /// </summary>
        public int IdAdicional { get; set; }
        /// <summary>
        /// Descripcion del adicional. Ejemplo: Adic. May. Dedicacion 33%; Adic. May. Horario 33%
        /// </summary>
        public string AdicionalDesc { get; set; } = null!;
        /// <summary>
        /// Porcentaje que corresponde al adicional. Ejemplo 33%; 50 %
        /// </summary>
        public int? Porcentaje { get; set; }
        /// <summary>
        /// Campo para eliminacion logica. Valor 0 es igual a falso, valor 1 es igual a verdadero
        /// </summary>
        public bool? EstaActivo { get; set; }
        /// <summary>
        /// Fecha en la que deja de estar activo el adicional
        /// </summary>
        public DateTime? FechaEliminacion { get; set; }

        public virtual ICollection<Presupuesto> Presupuestos { get; set; }
        public virtual ICollection<SubServicio> SubServicios { get; set; }
    }
}
