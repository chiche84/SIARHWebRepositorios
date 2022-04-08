using AutoMapper;

using SIARH.Aplication.DTOs;
using SIARH.Aplication.DTOs.RefEscalafon;
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
    //Commands
    public class RefEscalafonCreateCommand : RefEscalafonCreateDTO, IRequest<Result<RefEscalafonDTO>> 
    {

    }
    public class RefEscalafonUpdateCommand : RefEscalafonUpdateDTO, IRequest<Result<RefEscalafonDTO>> 
    {

    }
    public class RefEscalafonDeleteCommand : RefEscalafonDeleteDTO, IRequest<Result<RefEscalafonDTO>> 
    {

    }

    //Handler
    public class RefEscalafonEventHandler : IRequestHandler<RefEscalafonCreateCommand, Result<RefEscalafonDTO>>,
                                            IRequestHandler<RefEscalafonUpdateCommand, Result<RefEscalafonDTO>>,
                                            IRequestHandler<RefEscalafonDeleteCommand, Result<RefEscalafonDTO>>
    {
        private readonly RefEscalafonService RefEscalafonService;   
        public RefEscalafonEventHandler(RefEscalafonService RefEscalafonService)
        {
            this.RefEscalafonService = RefEscalafonService;
        }       
        public async Task<Result<RefEscalafonDTO>> Handle(RefEscalafonCreateCommand request, CancellationToken cancellationToken)
        {
           return  await RefEscalafonService.Create(request);
        }

        public async Task<Result<RefEscalafonDTO>> Handle(RefEscalafonUpdateCommand request, CancellationToken cancellationToken)
        {
            return await RefEscalafonService.Update(request);
        }

        public async Task<Result<RefEscalafonDTO>> Handle(RefEscalafonDeleteCommand request, CancellationToken cancellationToken)
        {
            return await RefEscalafonService.Delete(request);
        }
    }

}
