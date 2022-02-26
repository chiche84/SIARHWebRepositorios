using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class LicenciaPorSituacionDeRevistum
    {
        /// <summary>
        /// Clave foranea de la tabla Licencia, forma parte de la clave combinada que identifica la licencia y la situacion de revista permitida para esa licencia.
        /// </summary>
        public int IdLicencia { get; set; }
        /// <summary>
        /// Clave foranea de la tabla RefSituacionRevista, forma parte de la clave combinada que identifica la licencia y la situacion de revista permitida para esa licencia
        /// </summary>
        public int IdSituacionRevista { get; set; }
        /// <summary>
        /// Identifica si el registro esta activo.
        /// </summary>
        public bool? EstaActivo { get; set; }
        /// <summary>
        /// Almacena la fecha de alta de la licencia por situacion de revista.
        /// </summary>
        public DateTime FechaAlta { get; set; }
        /// <summary>
        /// Almacena la fecha de baja de la licencia por situacion de revista.
        /// </summary>
        public DateTime? FechaEliminacion { get; set; }

        public virtual Licencium IdLicenciaNavigation { get; set; } = null!;
        public virtual RefSituacionRevistum IdSituacionRevistaNavigation { get; set; } = null!;
    }
}
