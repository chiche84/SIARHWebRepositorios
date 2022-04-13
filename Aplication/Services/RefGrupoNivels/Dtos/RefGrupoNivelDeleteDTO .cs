using SIARH.Aplication.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIARH.Aplication.Services.RefGrupoNivels.Dtos
{
    public class RefGrupoNivelDeleteDTO : RefGrupoNivelDTO
    {

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public int IdGrupoNivel { get; set; }

    }
}
