using SIARH.Aplication.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIARH.Aplication.DTOs.RefEscalafon
{
    public class RefEscalafonDeleteDTO : RefEscalafonDTO
    {

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public int IdEscalafon { get; set; }

    }
}
