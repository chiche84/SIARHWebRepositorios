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
    public class RefEscalafonGet : IRequest<Result<RefEscalafonDTO>> { }
    public class RefEscalafonGetById : RefEscalafonDeleteDTO, IRequest<Result<RefEscalafonDTO>> { }
    public class RefEscalafonGetByEscalafonDesc : RefEscalafonGetByEscalafonDescDTO, IRequest<Result<RefEscalafonDTO>> {}
    public partial class RefEscalafonEventHandler : IRequestHandler<RefEscalafonGet, Result<RefEscalafonDTO>>,
                                            IRequestHandler<RefEscalafonGetById, Result<RefEscalafonDTO>>,
                                            IRequestHandler<RefEscalafonGetByEscalafonDesc, Result<RefEscalafonDTO>>
    {

        public async Task<Result<RefEscalafonDTO>> Handle(RefEscalafonGet request, CancellationToken cancellationToken)
        {
            return await RefEscalafonService.Get();
        }

        public async Task<Result<RefEscalafonDTO>> Handle(RefEscalafonGetById request, CancellationToken cancellationToken)
        {
            return await RefEscalafonService.GetById(request.IdEscalafon);
        }

        public async Task<Result<RefEscalafonDTO>> Handle(RefEscalafonGetByEscalafonDesc request, CancellationToken cancellationToken)
        {
            return await RefEscalafonService.GetByEscalafonDesc(request.EscalafonDesc);
        }
    }

    

}
