using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Me.Siarh.Pof.Domain.Entities
{
    public class GenericEntity
    {
        /// <summary>
        /// Clave primaria
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Indica si esta activa la funcion
        /// </summary>
        public bool? EstaActivo { get; set; }

    }
}
