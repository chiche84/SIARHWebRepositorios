using AutoMapper;

using Me.Siarh.Pof.Application.RefFuncionEntity.Dtos;
using MediatR;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using Me.Siarh.Pof.Application.RefFuncionEntity.Services;
using Me.Siarh.Common.Application;

namespace Me.Siarh.Pof.Application.RefFuncionEntity.Handlers
{
    //Commands
    public class RefFuncionCreateCommand : RefFuncionCreateDTO, IRequest<Result<RefFuncionDTO>> 
    {

    }
    public class RefFuncionUpdateCommand : RefFuncionUpdateDTO, IRequest<Result<RefFuncionDTO>> 
    {

    }
    public class RefFuncionDeleteCommand : RefFuncionDeleteDTO, IRequest<Result<RefFuncionDTO>> 
    {

    }

    //Handler
    public partial class RefFuncionEventHandler :   IRequestHandler<RefFuncionCreateCommand, Result<RefFuncionDTO>>,
                                                    IRequestHandler<RefFuncionUpdateCommand, Result<RefFuncionDTO>>,
                                                    IRequestHandler<RefFuncionDeleteCommand, Result<RefFuncionDTO>>
    {
        private readonly RefFuncionService _refFuncionService;   
        public RefFuncionEventHandler(RefFuncionService RefFuncionService)
        {
            this._refFuncionService = RefFuncionService;
        }       
        public async Task<Result<RefFuncionDTO>> Handle(RefFuncionCreateCommand request, CancellationToken cancellationToken)
        {
           return  await _refFuncionService.Create(request);
        }

        public async Task<Result<RefFuncionDTO>> Handle(RefFuncionUpdateCommand request, CancellationToken cancellationToken)
        {
            return await _refFuncionService.Update(request);
        }

        public async Task<Result<RefFuncionDTO>> Handle(RefFuncionDeleteCommand request, CancellationToken cancellationToken)
        {
            return await _refFuncionService.Delete(request);
        }
    }

}
