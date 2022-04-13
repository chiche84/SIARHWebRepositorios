using AutoMapper;

using SIARH.POF.Application.Entities.RefFuncionEntity.Dtos;
using SIARH.POF.Application.Common;

using MediatR;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace SIARH.POF.Application.Services
{
    public class RefFuncionGet : IRequest<Result<RefFuncionDTO>> { }
    public class RefFuncionGetById : RefFuncionDeleteDTO, IRequest<Result<RefFuncionDTO>> { }
    public class RefFuncionGetByEscalafonDesc : RefFuncionGetByFuncionDescDTO, IRequest<Result<RefFuncionDTO>> {}
    public partial class RefFuncionEventHandler : IRequestHandler<RefFuncionGet, Result<RefFuncionDTO>>,
                                            IRequestHandler<RefFuncionGetById, Result<RefFuncionDTO>>,
                                            IRequestHandler<RefFuncionGetByEscalafonDesc, Result<RefFuncionDTO>>
    {

        public async Task<Result<RefFuncionDTO>> Handle(RefFuncionGet request, CancellationToken cancellationToken)
        {
            return await RefFuncionService.Get();
        }

        public async Task<Result<RefFuncionDTO>> Handle(RefFuncionGetById request, CancellationToken cancellationToken)
        {
            return await RefFuncionService.GetById(request.IdFuncion);
        }

        public async Task<Result<RefFuncionDTO>> Handle(RefFuncionGetByEscalafonDesc request, CancellationToken cancellationToken)
        {
            return await RefFuncionService.GetByEscalafonDesc(request.FuncionDesc);
        }
    }

    

}
