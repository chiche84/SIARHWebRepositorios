using AutoMapper;

using SIARH.Aplication.DTOs;
using SIARH.Aplication.Interfaces;
using SIARH.Persistence.Filters;
using SIARH.Aplication.Models;
using SIARH.Persistence.Models;
using SIARH.Persistence.UnitOfWork;
using MediatR;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
                                      
namespace SIARH.Aplication.Services.RefGrupoNivels.Dtos
{
    //Commands
    public class RefGrupoNivelCreateCommand : RefGrupoNivelCreateDTO, IRequest<Result<RefGrupoNivelDTO>> 
    {

    }
    public class RefGrupoNivelUpdateCommand : RefGrupoNivelUpdateDTO, IRequest<Result<RefGrupoNivelDTO>> 
    {

    }
    public class RefGrupoNivelDeleteCommand : RefGrupoNivelDeleteDTO, IRequest<Result<RefGrupoNivelDTO>> 
    {

    }

    //Handler
    public class RefGrupoNivelEventHandler : IRequestHandler<RefGrupoNivelCreateCommand, Result<RefGrupoNivelDTO>>,
                                            IRequestHandler<RefGrupoNivelUpdateCommand, Result<RefGrupoNivelDTO>>,
                                            IRequestHandler<RefGrupoNivelDeleteCommand, Result<RefGrupoNivelDTO>>
    {
        private readonly RefGrupoNivelService RefGrupoNivelService;   
        public RefGrupoNivelEventHandler(RefGrupoNivelService RefGrupoNivelService)
        {
            this.RefGrupoNivelService = RefGrupoNivelService;
        }       
        public async Task<Result<RefGrupoNivelDTO>> Handle(RefGrupoNivelCreateCommand request, CancellationToken cancellationToken)
        {
           return  await RefGrupoNivelService.Create(request);
        }

        public async Task<Result<RefGrupoNivelDTO>> Handle(RefGrupoNivelUpdateCommand request, CancellationToken cancellationToken)
        {
            return await RefGrupoNivelService.Update(request);
        }

        public async Task<Result<RefGrupoNivelDTO>> Handle(RefGrupoNivelDeleteCommand request, CancellationToken cancellationToken)
        {
            return await RefGrupoNivelService.Delete(request);
        }
    }

}
