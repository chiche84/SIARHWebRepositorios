using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Me.Siarh.Pof.Domain.Entities
{
    public partial class RefFuncion
    {
        public RefFuncion()
        {
            //RefFuncionxEjers = new HashSet<RefFuncionxEjer>();
        }

        /// <summary>
        /// Clave primaria, NO autoincrementable. Identificador de funcion
        /// </summary>
        public int IdFuncion { get; set; }
        /// <summary>
        /// Descripcion de la funcion segun el presupuesto. Ejemplo: Educacion Elemental; Educacion media y tecnica; Educacion superior
        /// </summary>
        public string FuncionDesc { get; set; } = null!;
        /// <summary>
        /// Indica si esta activa la funcion
        /// </summary>
        public bool? EstaActivo { get; set; }
        /// <summary>
        /// Fecha que deja de estar activa la funcion
        /// </summary>
        public DateTime? FechaEliminacion { get; set; }

        //public virtual ICollection<RefFuncionxEjer> RefFuncionxEjers { get; set; }
    }
}
