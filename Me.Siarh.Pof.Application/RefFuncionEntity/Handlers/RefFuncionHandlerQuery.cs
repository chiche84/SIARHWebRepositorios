using AutoMapper;
using Me.Siarh.Common.Application;
using Me.Siarh.Pof.Application.RefFuncionEntity.Dtos;
using Me.Siarh.Pof.Application.RefFuncionEntity.Services;
using MediatR;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace Me.Siarh.Pof.Application.RefFuncionEntity.Handlers
{
    public class RefFuncionGet : IRequest<Result<RefFuncionDTO>> { }
    public class RefFuncionGetById : RefFuncionDeleteDTO, IRequest<Result<RefFuncionDTO>> { }
    public class RefFuncionGetByFuncionDesc : RefFuncionGetByFuncionDescDTO, IRequest<Result<RefFuncionDTO>> {}
    public partial class RefFuncionEventHandler : IRequestHandler<RefFuncionGet, Result<RefFuncionDTO>>,
                                            IRequestHandler<RefFuncionGetById, Result<RefFuncionDTO>>,
                                            IRequestHandler<RefFuncionGetByFuncionDesc, Result<RefFuncionDTO>>
    {

        public async Task<Result<RefFuncionDTO>> Handle(RefFuncionGet request, CancellationToken cancellationToken)
        {
            return await _refFuncionService.Get();
        }

        public async Task<Result<RefFuncionDTO>> Handle(RefFuncionGetById request, CancellationToken cancellationToken)
        {
            return await _refFuncionService.GetById(request.IdFuncion);
        }

        public async Task<Result<RefFuncionDTO>> Handle(RefFuncionGetByFuncionDesc request, CancellationToken cancellationToken)
        {
            return await _refFuncionService.GetByEscalafonDesc(request.FuncionDesc);
        }
    }

    

}
