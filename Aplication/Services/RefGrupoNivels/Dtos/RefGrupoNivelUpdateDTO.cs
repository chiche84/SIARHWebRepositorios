using SIARH.Aplication.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIARH.Aplication.Services.RefGrupoNivels.Dtos
{
    public class RefGrupoNivelUpdateDTO : RefGrupoNivelDTO
    {
        public int IdGrupoNivel { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(120)]
        public string? GrupoDesc { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(120)]
    
        public bool EstaActivo { get; set; }

    }
}
