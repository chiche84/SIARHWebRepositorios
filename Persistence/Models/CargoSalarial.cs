using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    /// <summary>
    /// Categoria que puede ser asignada a un agente y por el cual se liquidara
    /// </summary>
    public partial class CargoSalarial
    {
        public CargoSalarial()
        {
            CargoSalarialFuncionals = new HashSet<CargoSalarialFuncional>();
            Presupuestos = new HashSet<Presupuesto>();
            SolicitudPlazaDetalles = new HashSet<SolicitudPlazaDetalle>();
            SolicitudPlazaSitExts = new HashSet<SolicitudPlazaSitExt>();
        }

        /// <summary>
        /// Clave primaria, autoincrementable.Codigo identificador del cargo salarial.
        /// </summary>
        public int IdCargoSalarial { get; set; }
        /// <summary>
        /// Descripcion del cargo salarial
        /// </summary>
        public string CargoSalarialDesc { get; set; } = null!;
        /// <summary>
        /// Clave foranea de la tabla RefJornada. 
        /// </summary>
        public int IdJornada { get; set; }
        /// <summary>
        /// Equivalencia del cargo salarial en horas
        /// </summary>
        public int? EquivalenciaHoraria { get; set; }
        public int? OrdenVisual { get; set; }
        /// <summary>
        /// Identifica si el registro esta activo.
        /// </summary>
        public bool? EstaActivo { get; set; }
        /// <summary>
        /// Almacena la fecha de alta del cargo salarial.
        /// </summary>
        public DateTime? FechaAlta { get; set; }
        /// <summary>
        /// Almacena la fecha de baja del cargo salarial.
        /// </summary>
        public DateTime? FechaEliminacion { get; set; }
        public bool? Nuevo { get; set; }

        public virtual RefJornadum IdJornadaNavigation { get; set; } = null!;
        public virtual ICollection<CargoSalarialFuncional> CargoSalarialFuncionals { get; set; }
        public virtual ICollection<Presupuesto> Presupuestos { get; set; }
        public virtual ICollection<SolicitudPlazaDetalle> SolicitudPlazaDetalles { get; set; }
        public virtual ICollection<SolicitudPlazaSitExt> SolicitudPlazaSitExts { get; set; }
    }
}
