using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    /// <summary>
    /// Presupuesto anual de plazas por finalidad, funcion y escalafon
    /// </summary>
    public partial class Presupuesto
    {
        public Presupuesto()
        {
            PlazaPresupuestos = new HashSet<PlazaPresupuesto>();
        }

        public int IdPresupuesto { get; set; }
        public int IdEscalafon { get; set; }
        /// <summary>
        /// Clave foranea. Identificador de Categoria presupuesto
        /// </summary>
        public int IdCargoSalarial { get; set; }
        /// <summary>
        /// Identificador de adicional. Ejemplo 1 - 33% mayor responsabilidad
        /// </summary>
        public int IdAdicional { get; set; }
        /// <summary>
        /// Cantidad de plazas correspondiente a una finalidad, funcion, categoria y escalafon en particular presupuestadas para el año actual
        /// </summary>
        public int CantPresupuestada { get; set; }
        /// <summary>
        /// Unidad de organización para la cual se destina el presupuesto de plazas
        /// </summary>
        public int IdUdeOxEjer { get; set; }
        public int? IdFinalidadxEjer { get; set; }
        public int? IdFuncionxEjer { get; set; }
        /// <summary>
        /// Campo para eliminacion logica. Valor 0 es igual a falso, valor 1 es igual a verdadero
        /// </summary>
        public bool? EstaActivo { get; set; }
        /// <summary>
        /// Campo para borrado lógico. Fecha en la que deja de estar activo el items de presupuesto
        /// </summary>
        public DateTime? FechaEliminacion { get; set; }
        /// <summary>
        /// Inicialmente toma el valor de cantidad presupuestada, luego a medida que se van creando plazas se va descontando este valor,
        /// </summary>
        public int? CantDisponible { get; set; }

        public virtual RefAdicional IdAdicionalNavigation { get; set; } = null!;
        public virtual CargoSalarial IdCargoSalarialNavigation { get; set; } = null!;
        public virtual RefEscalafon IdEscalafonNavigation { get; set; } = null!;
        public virtual RefFinalidadxEjer? IdFinalidadxEjerNavigation { get; set; }
        public virtual RefFuncionxEjer? IdFuncionxEjerNavigation { get; set; }
        public virtual RefUdeOxEjer IdUdeOxEjerNavigation { get; set; } = null!;
        public virtual ICollection<PlazaPresupuesto> PlazaPresupuestos { get; set; }
    }
}
