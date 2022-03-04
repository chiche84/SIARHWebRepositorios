using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIARH.Aplication.DTOs
{
    public class totalDTO: RefEscalafonCreacionDTO
    {
        public int IdAmbito { get; set; }
        public string? AmbitoDesc { get; set; }
    }

}
