using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIARH.Aplication.DTOs
{
    public class RefEscalafonCreacionDTO
    {
        public int IdEscalafon { get; set; }
        public string EscalafonDesc { get; set; } = null!;
        public string? Nomenclatura { get; set; }
        public int? IdGrupoNivel { get; set; }
    }
}
