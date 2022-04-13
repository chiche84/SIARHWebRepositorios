using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIARH.POF.Application.Entities.RefFuncionEntity.Dtos
{
    public class RefFuncionGetByIdDTO : RefFuncionDTO
    {

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public int IdFuncion { get; set; }

    }
}
