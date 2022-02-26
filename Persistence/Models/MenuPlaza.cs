using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    /// <summary>
    /// Menu dinamico de la aplicacion
    /// </summary>
    public partial class MenuPlaza
    {
        public MenuPlaza()
        {
            InverseIdMenuPadreNavigation = new HashSet<MenuPlaza>();
        }

        /// <summary>
        /// Identificador del item que compone el menu
        /// </summary>
        public int IdMenu { get; set; }
        /// <summary>
        /// Identificador el Item padre del que depende
        /// </summary>
        public int IdMenuPadre { get; set; }
        public bool? MenuPersonalizado { get; set; }
        /// <summary>
        /// Orden que se visualizara en el menu
        /// </summary>
        public int? MenuOrden { get; set; }
        /// <summary>
        /// Valor que se asigna al campo Value cuando se diseña el menu en tiempo real
        /// </summary>
        public bool? MenuSeleccionable { get; set; }
        /// <summary>
        /// Link a la pagina que realizara la accion del item del menu
        /// </summary>
        public string? MenuUrl { get; set; }
        /// <summary>
        /// Nombre de la tabla que esta asociado al item del menu
        /// </summary>
        public string? MenuTabla { get; set; }
        /// <summary>
        /// Imagen o icono que se visualizara en el item del menu
        /// </summary>
        public string? MenuImagen { get; set; }
        /// <summary>
        /// Descripcion del item de menu que se visualizara
        /// </summary>
        public string? MenuNombre { get; set; }
        public int? IdDetalleTabla { get; set; }
        public bool? EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }

        public virtual DetalleTabla? IdDetalleTablaNavigation { get; set; }
        public virtual MenuPlaza IdMenuPadreNavigation { get; set; } = null!;
        public virtual ICollection<MenuPlaza> InverseIdMenuPadreNavigation { get; set; }
    }
}
