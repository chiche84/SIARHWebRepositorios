using AutoMapper;

using SIARH.Aplication.DTOs;
using SIARH.Aplication.Services.RefGrupoNivels.Dtos;
using SIARH.Aplication.Interfaces;
using SIARH.Persistence.Filters;
using SIARH.Aplication.Models;
using SIARH.Persistence.Models;
using SIARH.Persistence.UnitOfWork;
using MediatR;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace SIARH.Aplication.Services
{
    public class RefGrupoNivelGetQuery : IRequest<Result<RefGrupoNivelDTO>> { }
    public class RefGrupoNivelGetByIdQuery : RefGrupoNivelDeleteDTO, IRequest<Result<RefGrupoNivelDTO>> { }
    public class RefGrupoNivelGetByEscalafonDescQuery : RefGrupoNivelGetByGrupoDescDTO, IRequest<Result<RefGrupoNivelDTO>> {}
    public class RefGrupoNivelHandlerQuery : IRequestHandler<RefGrupoNivelGetQuery, Result<RefGrupoNivelDTO>>,
                                            IRequestHandler<RefGrupoNivelGetByIdQuery, Result<RefGrupoNivelDTO>>,
                                            IRequestHandler<RefGrupoNivelGetByEscalafonDescQuery, Result<RefGrupoNivelDTO>>
    {
        private readonly RefGrupoNivelService RefGrupoNivelService;

        public RefGrupoNivelHandlerQuery(RefGrupoNivelService RefGrupoNivelService)
        {
            this.RefGrupoNivelService = RefGrupoNivelService;
        }

        public async Task<Result<RefGrupoNivelDTO>> Handle(RefGrupoNivelGetQuery request, CancellationToken cancellationToken)
        {
            return await RefGrupoNivelService.Get();
        }

        public async Task<Result<RefGrupoNivelDTO>> Handle(RefGrupoNivelGetByIdQuery request, CancellationToken cancellationToken)
        {
            return await RefGrupoNivelService.GetById(request.IdGrupoNivel);
        }

        public async Task<Result<RefGrupoNivelDTO>> Handle(RefGrupoNivelGetByEscalafonDescQuery request, CancellationToken cancellationToken)
        {
            return await RefGrupoNivelService.GetByGrupoDesc(request.GrupoDesc);
        }
    }

    

}
