using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIARH.Aplication.DTOs.RefAmbito
{
    public class RefAmbitoGetDTO : RefAmbitoDTO
    {
        public int IdAmbito { get; set; }

        public string? AmbitoDesc { get; set; }

        public bool EstaActivo { get; set; }
    }
}
