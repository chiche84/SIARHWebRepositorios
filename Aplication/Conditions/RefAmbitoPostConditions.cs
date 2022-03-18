using SIARH.Aplication.DTOs;
using SIARH.Aplication.Interfaces;
using SIARH.Aplication.Models;
using SIARH.Persistence.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIARH.Aplication.Conditions
{
    internal class RefAmbitoPostConditions: GenericPostConditions<RefAmbito, IRefAmbitoDTO >, IPostConditions<RefAmbito, IRefAmbitoDTO>
    {
        public override async Task<Result<IRefAmbitoDTO>> IsValid(RefAmbito entity)
        {
            return Result<IRefAmbitoDTO>.Failure(new string[] { "error en post condiciones" });
        }
    }
}
