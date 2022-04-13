using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIARH.POF.Application.Common;
using SIARH.POF.Application.Entities.RefFuncionEntity.Dtos;
using SIARH.POF.Persistence.Models;

namespace SIARH.POF.Application.Entities.RefFuncionEntity
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
        }
    }
}
