using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class DetalleTabla
    {
        public DetalleTabla()
        {
            MenuPlazas = new HashSet<MenuPlaza>();
        }

        public int IdDetalleTabla { get; set; }
        /// <summary>
        /// Nombre de la tabla
        /// </summary>
        public string Tabla { get; set; } = null!;
        /// <summary>
        /// Descripcion larga de los valores que contiene la tabla
        /// </summary>
        public string Descripcion { get; set; } = null!;
        /// <summary>
        /// Identifica si el registro esta activo o no
        /// </summary>
        public bool? EstaActivo { get; set; }
        /// <summary>
        /// Almacena la fecha de baja del registro.
        /// </summary>
        public DateTime? FechaEliminacion { get; set; }
        /// <summary>
        /// Indica si el registro esta o no vinculado a una tabla determinada de la base de datos
        /// </summary>
        public bool? Vinculado { get; set; }

        public virtual ICollection<MenuPlaza> MenuPlazas { get; set; }
    }
}
