using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    /// <summary>
    /// Motivos de creacion. Ejemplo: POF, NO POF
    /// </summary>
    public partial class RefMotivoCreacion
    {
        public RefMotivoCreacion()
        {
            Plazas = new HashSet<Plaza>();
        }

        /// <summary>
        /// Clave primaria, autoincrementable. Identificador de motivo de creacion
        /// </summary>
        public int IdMotivoCreacion { get; set; }
        /// <summary>
        /// Indica si el cargo es POF (pertenece a la planta) o NO POF (no pertenece a la planta)
        /// </summary>
        public string MotivoCreacionDesc { get; set; } = null!;
        public bool? EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }

        public virtual ICollection<Plaza> Plazas { get; set; }
    }
}
