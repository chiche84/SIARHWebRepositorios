using SIARH.Aplication.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIARH.Aplication.DTOs.RefEscalafon
{
    public class RefEscalafonUpdateDTO : RefEscalafonDTO
    {
        public int IdEscalafon { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(120)]
        public string? EscalafonDesc { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(120)]
        public string? Nomenclatura { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public int? IdGrupoNivel { get; set; }
        public bool EstaActivo { get; set; }

    }
}
