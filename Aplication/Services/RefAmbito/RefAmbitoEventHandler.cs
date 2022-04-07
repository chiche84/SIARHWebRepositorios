using AutoMapper;

using SIARH.Aplication.DTOs;
using SIARH.Aplication.DTOs.RefAmbito;
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
    public class RefAmbitoCreateCommand : RefAmbitoCreateDTO, IRequest<Result<RefAmbitoDTO>> //inotification no retorna nada, en caso de querer retornar, usar IRequest
    {

    }
    public class RefAmbitoEventHandler : IRequestHandler<RefAmbitoCreateCommand, Result<RefAmbitoDTO>>
    {
        private readonly RefAmbitoService refAmbitoService;   
        public RefAmbitoEventHandler(RefAmbitoService refAmbitoService)
        {
            this.refAmbitoService = refAmbitoService;
        }       
        public async Task<Result<RefAmbitoDTO>> Handle(RefAmbitoCreateCommand request, CancellationToken cancellationToken)
        {
           return  await refAmbitoService.Create(request);
        }  
    }

    
    public class RefAmbitoRequestModel: IRequest<Result<RefAmbitoDTO>> {}

    public class GetRefAmbitoEventHandler : IRequestHandler<RefAmbitoRequestModel, Result<RefAmbitoDTO>>
    {
        private readonly RefAmbitoService refAmbitoService;
        public GetRefAmbitoEventHandler(RefAmbitoService refAmbitoService)
        {
            this.refAmbitoService = refAmbitoService;
        }
        public async Task<Result<RefAmbitoDTO>> Handle(RefAmbitoRequestModel request, CancellationToken cancellationToken)
        {
            var response = await refAmbitoService.Get();
            return response;
        }
    }

    

}
