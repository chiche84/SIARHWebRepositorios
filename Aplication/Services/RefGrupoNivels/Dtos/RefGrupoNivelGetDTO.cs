using SIARH.Aplication.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIARH.Aplication.Services.RefGrupoNivels.Dtos
{
    public class RefGrupoNivelGetDTO : RefGrupoNivelDTO
    {
        public int IdGrupoNivel { get; set; }

        public string? GrupoDesc { get; set; }

        public bool EstaActivo { get; set; }

    }
}
