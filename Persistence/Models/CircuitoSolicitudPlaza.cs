using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class CircuitoSolicitudPlaza
    {
        public CircuitoSolicitudPlaza()
        {
            SolicitudEstados = new HashSet<SolicitudEstado>();
            SolicitudPlazaDetalles = new HashSet<SolicitudPlazaDetalle>();
        }

        public int IdCircuitoSol { get; set; }
        /// <summary>
        /// Descripción de parte interviniente del circuito de solicitud de cargos. Ejemplo: Supervision regional, dirección de nivel
        /// </summary>
        public string CircuitoSolDesc { get; set; } = null!;
        /// <summary>
        /// Identificador de nivel educativo agrupado. Ejemplo: Nivel inicial y primaria, Secundaria, terciaria
        /// </summary>
        public int IdGrupoNivel { get; set; }
        /// <summary>
        /// Orden dentro del circuito. Ejemplo la solicitud inicia en la Organizacion, 2. Supervisión regional, 3 Dirección de nivel
        /// </summary>
        public int? Orden { get; set; }
        public int EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }
        /// <summary>
        /// Tipo de solicitud: Ejemplo: Plaza, designación, licencia, etc.
        /// </summary>
        public int IdTipoSolicitud { get; set; }

        public virtual RefTipoSolicitud IdTipoSolicitudNavigation { get; set; } = null!;
        public virtual ICollection<SolicitudEstado> SolicitudEstados { get; set; }
        public virtual ICollection<SolicitudPlazaDetalle> SolicitudPlazaDetalles { get; set; }
    }
}
