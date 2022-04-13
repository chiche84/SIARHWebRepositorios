using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Me.Siarh.Pof.Application.RefFuncionEntity.Dtos
{
    public class RefFuncionGetDTO : RefFuncionDTO
    {
        public int IdFuncion { get; set; }

        public string? FuncionDesc { get; set; }

        public bool EstaActivo { get; set; }

    }
}
