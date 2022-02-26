using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    /// <summary>
    /// Movimientos que puede realizar un agente. Ejemplo:  alta, licencia, reubicacion, continuidad
    /// </summary>
    public partial class RefMovimiento
    {
        public RefMovimiento()
        {
            Servicios = new HashSet<Servicio>();
            SolicitudDetalles = new HashSet<SolicitudDetalle>();
            SubServicios = new HashSet<SubServicio>();
        }

        /// <summary>
        /// Clave primaria, autoincrementable. Identificador de movimiento docente
        /// </summary>
        public int IdMovimiento { get; set; }
        public int IdTipoMovimiento { get; set; }
        /// <summary>
        /// Descripcion del movimiento que puede realizar un agente. Ejemplo: alta, licencia, reubicacion, continuidad
        /// </summary>
        public string MovimientoDesc { get; set; } = null!;
        /// <summary>
        /// Campo para eliminacion logica. Valor 0 es igual a falso, valor 1 es igual a verdadero
        /// </summary>
        public bool? EstaActivo { get; set; }
        /// <summary>
        /// Fecha en la que deja de estar activo el movimiento docente
        /// </summary>
        public DateTime? FechaEliminacion { get; set; }
        public bool GeneraSuplente { get; set; }
        public int? IdTipoMovIdRrhh { get; set; }

        public virtual RefTipoMovimiento IdTipoMovimientoNavigation { get; set; } = null!;
        public virtual Licencium Licencium { get; set; } = null!;
        public virtual ICollection<Servicio> Servicios { get; set; }
        public virtual ICollection<SolicitudDetalle> SolicitudDetalles { get; set; }
        public virtual ICollection<SubServicio> SubServicios { get; set; }
    }
}
