using AutoMapper;
using Me.Siarh.Common.Application;
using Me.Siarh.Pof.Application.RefFuncionEntity.Dtos;
using Me.Siarh.Pof.Domain.Entities;
using Me.Siarh.Pof.Persistence.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Me.Siarh.Pof.Application
{
    public class RefFuncionProfile : Profile
    {
        public RefFuncionProfile()
        {
            CreateMap<RefFuncionDTO, RefFuncion>().ReverseMap();
            CreateMap<RefFuncionCreateDTO, RefFuncion>().ReverseMap();
            CreateMap<RefFuncionUpdateDTO, RefFuncion>().ReverseMap();
            CreateMap<RefFuncionDeleteDTO, RefFuncion>().ReverseMap();
            CreateMap<RefFuncionGetDTO, RefFuncion>().ReverseMap();
            CreateMap<Result<RefFuncionGetDTO>, Result<RefFuncionDTO>>().ReverseMap();
            CreateMap<RefFuncionGetByFilterDTO, RefFuncionFilter>().ReverseMap();
        }
    }
}
