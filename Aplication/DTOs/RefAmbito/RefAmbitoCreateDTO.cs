using SIARH.Aplication.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIARH.Aplication.DTOs.RefAmbito
{
    public class RefAmbitoCreateDTO : RefAmbitoDTO
    {
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(120)]
        public string? AmbitoDesc { get; set; }
    }
}
