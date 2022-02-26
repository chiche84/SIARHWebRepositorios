using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    /// <summary>
    /// Funciones que puede desempeñar un agente, independientemente del cargo salarial asignado (cargo para liquidacion).
    /// </summary>
    public partial class CargoFuncional
    {
        public CargoFuncional()
        {
            CargoSalarialFuncionals = new HashSet<CargoSalarialFuncional>();
            Plazas = new HashSet<Plaza>();
            ReqSolicitudPrimaria = new HashSet<ReqSolicitudPrimarium>();
            SolicitudPlazaDetalles = new HashSet<SolicitudPlazaDetalle>();
            SolicitudPlazaSitExts = new HashSet<SolicitudPlazaSitExt>();
        }

        /// <summary>
        /// Clave primaria, autoincrementable. Identificador de la funcion que podría cumplir un agente
        /// </summary>
        public int IdCargoFuncional { get; set; }
        /// <summary>
        /// Descripción del cargo funcional
        /// </summary>
        public string CargoFuncionalDesc { get; set; } = null!;
        /// <summary>
        /// Indica si se trata de un cargo funcional directivo. Valor 0 es igual a falso, valor 1 igual a verdadero. Ejemplo: Cargo funcional Director de primera categoria es Jerarquico = 1
        /// </summary>
        public bool? EsJerarquico { get; set; }
        public int? OrdenVisual { get; set; }
        /// <summary>
        /// Campo para eliminación lógica. Valor 0 es igual a falso, valor 1 es igual a verdadero
        /// </summary>
        public bool? EstaActivo { get; set; }
        /// <summary>
        /// Fecha en la que deja de estar activo el cargo funcional
        /// </summary>
        public DateTime? FechaEliminacion { get; set; }
        /// <summary>
        /// Clave foranea. Identificador de tipo de funcion. Las funciones son agrupadas por tipo
        /// </summary>
        public int? IdTipoFuncion { get; set; }

        public virtual RefTipoFuncion? IdTipoFuncionNavigation { get; set; }
        public virtual ICollection<CargoSalarialFuncional> CargoSalarialFuncionals { get; set; }
        public virtual ICollection<Plaza> Plazas { get; set; }
        public virtual ICollection<ReqSolicitudPrimarium> ReqSolicitudPrimaria { get; set; }
        public virtual ICollection<SolicitudPlazaDetalle> SolicitudPlazaDetalles { get; set; }
        public virtual ICollection<SolicitudPlazaSitExt> SolicitudPlazaSitExts { get; set; }
    }
}
