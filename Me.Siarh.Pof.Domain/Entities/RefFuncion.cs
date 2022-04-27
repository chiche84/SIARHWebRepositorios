using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Me.Siarh.Pof.Domain.Entities
{
    public partial class RefFuncion : GenericEntity   {
        public RefFuncion()
        {
            //RefFuncionxEjers = new HashSet<RefFuncionxEjer>();
        }

        /// <summary>
        /// Descripcion de la funcion segun el presupuesto. Ejemplo: Educacion Elemental; Educacion media y tecnica; Educacion superior
        /// </summary>
        public string FuncionDesc { get; set; } = null!;
        /// <summary>
        /// Fecha que deja de estar activa la funcion
        /// </summary>
        public DateTime? FechaEliminacion { get; set; }

        //public virtual ICollection<RefFuncionxEjer> RefFuncionxEjers { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

    }
}
