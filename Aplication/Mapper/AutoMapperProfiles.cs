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
            CreateMap<RefAmbitoCreateDTO, RefAmbitoDTO>().ReverseMap(); 
            CreateMap<RefAmbitoUpdateDTO, RefAmbitoDTO>().ReverseMap();

            CreateMap<RefEscalafonDTO, RefEscalafon>().ReverseMap();
            CreateMap<RefEscalafonCreateDTO, RefEscalafonDTO>().ReverseMap();
            CreateMap<RefEscalafonUpdateDTO, RefEscalafonDTO>().ReverseMap();


        }
    }
}
