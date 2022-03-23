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
            CreateMap<RefAmbitoDTO, RefAmbito>().ReverseMap();
            CreateMap<RefAmbitoUpdateDTO, RefAmbitoDTO>().ReverseMap();

            CreateMap<RefEscalafonCreacionDTO, RefEscalafon>();


        }
    }
}
