using AutoMapper;
using MediatR;
using Me.Siarh.Pof.Application.RefFuncionEntity.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Me.Siarh.Common.Application;
using Me.Siarh.Pof.Persistence;
using Me.Siarh.Pof.Persistence.Filters;
using Me.Siarh.Pof.Persistence.UnitOfWork;
using Me.Siarh.Pof.Domain.Entities;
using Me.Siarh.Common.Persistence;

namespace Me.Siarh.Pof.Application.RefFuncionEntity.Services
{
    public partial class RefFuncionService : GenericService<RefFuncionDTO, RefFuncionGetByFilterDTO, GenericRepository<RefFuncion, RefFuncionFilter>,RefFuncion,RefFuncionFilter, RefFuncionGetDTO>
    {
        private readonly UnitOfWork unitOfWork;

        public RefFuncionService(UnitOfWork unitOfWork,  IMapper mapper) : base(mapper, unitOfWork.RefFuncionRepository)
        {
            this.unitOfWork = unitOfWork;
        }

        public void OtherMethod()
        {
            unitOfWork.RefFuncionRepository.OtherMethod();
        }

               
    }
}
