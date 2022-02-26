using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    /// <summary>
    /// Divisiones que pertenecen a determinado grupo de divisiones. Ejemplo: grupo de divisiones, (1A, 1B, 1D) que integran la asignatura de Educacion fisica
    /// </summary>
    public partial class GrupoDivision
    {
        /// <summary>
        /// Clave primaria, autoincrementable.Codigo identificador de grupo division.
        /// </summary>
        public int IdGrupoDivision { get; set; }
        public int IdDivisionCabecera { get; set; }
        /// <summary>
        /// Identifica cada una de las divisiones asociadas al grupo.
        /// </summary>
        public int IdDivision { get; set; }
        public bool? EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }

        public virtual Division IdDivisionCabeceraNavigation { get; set; } = null!;
        public virtual Division IdDivisionNavigation { get; set; } = null!;
    }
}
