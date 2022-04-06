using SIARH.Aplication.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIARH.Aplication.DTOs.RefEscalafon
{
    public class RefEscalafonGetDTO : RefEscalafonDTO
    {
        public int IdEscalafon { get; set; }

        public string? EscalafonDesc { get; set; }

        public string? Nomenclatura { get; set; }

        public int? IdGrupoNivel { get; set; }

        public bool EstaActivo { get; set; }

        public string GrupoDesc { get; set; }

    }
}
