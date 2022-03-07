using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoMapper;

using SIARH.Aplication.DTOs;
using SIARH.Persistence.Models;

namespace SIARH.Aplication.Mapper
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<RefAmbitoCreacionDTO, RefAmbito>();
            CreateMap<RefEscalafonCreacionDTO, RefEscalafon>();
            CreateMap<totalDTO, RefAmbito>();
            CreateMap<totalDTO, RefEscalafon>();
        }
    }
}
