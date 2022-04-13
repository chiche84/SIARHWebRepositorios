using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIARH.Persistence.Models;
    

namespace SIARH.Aplication.Services.RefGrupoNivels.Dtos
{
    public class RefGrupoNivelProfile : Profile
    {
        public RefGrupoNivelProfile()
        {
            CreateMap<SIARH.Persistence.Models.RefGrupoNivel, RefGrupoNivelCreateDTO>();
            CreateMap<RefGrupoNivelDTO, SIARH.Persistence.Models.RefGrupoNivel > ().ReverseMap();
            CreateMap<RefGrupoNivelCreateDTO, SIARH.Persistence.Models.RefGrupoNivel > ().ReverseMap();
            CreateMap<RefGrupoNivelUpdateDTO, SIARH.Persistence.Models.RefGrupoNivel > ().ReverseMap();
            CreateMap<RefGrupoNivelDeleteDTO, SIARH.Persistence.Models.RefGrupoNivel > ().ReverseMap();
        }
    }
}
