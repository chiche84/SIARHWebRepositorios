using AutoMapper;

using SIARH.POF.Application;
using SIARH.POF.Application.Entities.RefFuncionEntity.Dtos;
using SIARH.POF.Application.Common;
using MediatR;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using SIARH.POF.Application.Entities.RefFuncionEntity.Services;

namespace SIARH.POF.Application.Services
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
        private readonly RefFuncionService RefFuncionService;   
        public RefFuncionEventHandler(RefFuncionService RefFuncionService)
        {
            this.RefFuncionService = RefFuncionService;
        }       
        public async Task<Result<RefFuncionDTO>> Handle(RefFuncionCreateCommand request, CancellationToken cancellationToken)
        {
           return  await RefFuncionService.Create(request);
        }

        public async Task<Result<RefFuncionDTO>> Handle(RefFuncionUpdateCommand request, CancellationToken cancellationToken)
        {
            return await RefFuncionService.Update(request);
        }

        public async Task<Result<RefFuncionDTO>> Handle(RefFuncionDeleteCommand request, CancellationToken cancellationToken)
        {
            return await RefFuncionService.Delete(request);
        }
    }

}
