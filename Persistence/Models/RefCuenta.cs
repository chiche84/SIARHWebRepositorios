using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class RefCuenta
    {
        public RefCuenta()
        {
            InverseIdNodoPadreNavigation = new HashSet<RefCuenta>();
            Partida = new HashSet<Partidum>();
        }

        public int IdCuenta { get; set; }
        public short Seccion1 { get; set; }
        public short Seccion2 { get; set; }
        public short Sector1 { get; set; }
        public short Sector2 { get; set; }
        public short Partida1 { get; set; }
        public short Partida2 { get; set; }
        public string Cuenta { get; set; } = null!;
        /// <summary>
        /// 0: Clasificación, 1: Nodo Hoja que contiene partidas
        /// </summary>
        public bool Tipo { get; set; }
        public int? IdNodoPadre { get; set; }
        public short? Nivel { get; set; }
        public bool? EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }

        public virtual RefCuenta? IdNodoPadreNavigation { get; set; }
        public virtual ICollection<RefCuenta> InverseIdNodoPadreNavigation { get; set; }
        public virtual ICollection<Partidum> Partida { get; set; }
    }
}
