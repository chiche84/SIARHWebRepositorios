using AutoMapper;
using Me.Siarh.Common.Application;
using Me.Siarh.Pof.Application.RefFuncionEntity.Dtos;
using Me.Siarh.Pof.Application.RefFuncionEntity.Services;
using MediatR;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace Me.Siarh.Pof.Application.RefFuncionEntity.Handlers
{
    public class RefFuncionGetById : RefFuncionGetByIdDTO, IRequest<Result<RefFuncionDTO>> { }
    public class RefFuncionGetByFilter : RefFuncionGetByFilterDTO, IRequest<Result<RefFuncionDTO>> { }


    public partial class RefFuncionEventHandler : IRequestHandler<RefFuncionGetById, Result<RefFuncionDTO>>,
                                                  IRequestHandler<RefFuncionGetByFilter, Result<RefFuncionDTO>>
    {

        public async Task<Result<RefFuncionDTO>> Handle(RefFuncionGetById request, CancellationToken cancellationToken)
        {
            return await _refFuncionService.GetById(request.IdFuncion);
        }

        public async Task<Result<RefFuncionDTO>> Handle(RefFuncionGetByFilter request, CancellationToken cancellationToken)
        {
            return await _refFuncionService.GetByFilter(request);
        }
    }

}
