using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoMapper;

using SIARH.Aplication.DTOs;
using SIARH.Aplication.DTOs.RefAmbito;
using SIARH.Aplication.DTOs.RefEscalafon;
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
            CreateMap<RefAmbitoGetDTO, RefAmbito>().ReverseMap();
            CreateMap<Result<RefAmbitoGetDTO>, Result<RefAmbitoDTO>>().ReverseMap();

            CreateMap<RefEscalafonDTO, RefEscalafon>().ReverseMap();
            CreateMap<RefEscalafonCreateDTO, RefEscalafon>().ReverseMap();
            CreateMap<RefEscalafonUpdateDTO, RefEscalafon>().ReverseMap();
            CreateMap<RefEscalafonDeleteDTO, RefEscalafon>().ReverseMap();

            var mapRefEscalafonGetDTO = CreateMap<RefEscalafon, RefEscalafonGetDTO>();
            mapRefEscalafonGetDTO.ForMember(dest => dest.GrupoDesc, opt => opt.MapFrom(src => src.IdGrupoNivelNavigation.GrupoDesc));


            CreateMap<Result<RefEscalafonGetDTO>, Result<RefEscalafonDTO>>().ReverseMap();
                
        }
    }
}
