using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoMapper;

using SIARH.Aplication.DTOs;
using SIARH.Aplication.DTOs.RefAmbito;
using SIARH.Aplication.Models;
using SIARH.Persistence.Models;

namespace SIARH.Aplication.Mapper
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<RefAmbitoDTO, RefAmbito>().ReverseMap();
            CreateMap<RefAmbitoCreateDTO, RefAmbito>().ReverseMap();
            CreateMap<RefAmbitoUpdateDTO, RefAmbito>().ReverseMap();
            CreateMap<RefAmbitoViewDTO, RefAmbito>().ReverseMap();
            CreateMap<Result<RefAmbitoViewDTO>, Result<RefAmbitoDTO>>().ReverseMap();

            CreateMap<RefEscalafonDTO, RefEscalafon>().ReverseMap();
            CreateMap<RefEscalafonCreateDTO, RefEscalafonDTO>().ReverseMap();
            CreateMap<RefEscalafonUpdateDTO, RefEscalafonDTO>().ReverseMap();


        }
    }
}
