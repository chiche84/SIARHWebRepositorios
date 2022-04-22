using Me.Siarh.Common.Application;
using Me.Siarh.Common.Persistence;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Me.Siarh.Pof.Application.RefFuncionEntity.Dtos
{
    public class RefFuncionGetByFilterDTO : GenericFilter, IFilterDTO
    {

        public string? FuncionDesc { get; set; }
        public string? FuncionDescContains { get; set; }

        public RefFuncionGetByFilterDTO()
        {
            PageNumber = 1;
            PageSize = 10;
        }

    }
}
