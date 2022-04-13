using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Me.Siarh.Pof.Application.RefFuncionEntity.Dtos
{
    public class RefFuncionDeleteDTO : RefFuncionDTO
    {

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public int IdFuncion { get; set; }

    }
}
