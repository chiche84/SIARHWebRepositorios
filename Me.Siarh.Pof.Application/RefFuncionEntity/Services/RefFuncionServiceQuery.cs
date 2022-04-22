using AutoMapper;
using Me.Siarh.Common.Application;
using Me.Siarh.Pof.Application.RefFuncionEntity.Dtos;
using Me.Siarh.Pof.Domain.Entities;
using Me.Siarh.Pof.Persistence.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Me.Siarh.Pof.Application.RefFuncionEntity.Services
{
    public partial class RefFuncionService 
    {

        public override async Task<Result<RefFuncionDTO>> GetById(int id)
        {

            List<RefFuncionDTO> entitiesOut = new List<RefFuncionDTO>();

            IEnumerable<RefFuncion> entitiesIn = await unitOfWork.RefFuncionRepository.FilterPaginated(new RefFuncionFilter() { Id = id, EstaActivo = true});

            entitiesOut.AddRange(mapper.Map<List<RefFuncionGetDTO>>(entitiesIn));
     
            if (entitiesOut.Count != 1)
            {
                return Result<RefFuncionDTO>.Failure(entitiesOut, new string[] { "No se encuentra Escalafon." });
            }

            return Result<RefFuncionDTO>.Success(entitiesOut.Single());
        }

        public override async Task<Result<RefFuncionDTO>> GetByFilter(RefFuncionGetByFilterDTO refFuncionGetByFilterDTO)
        {
            List<RefFuncionDTO> entitiesOut = new List<RefFuncionDTO>();

            IEnumerable<RefFuncion> entitiesIn = await unitOfWork.RefFuncionRepository.FilterPaginated(mapper.Map<RefFuncionFilter>(refFuncionGetByFilterDTO));

            entitiesOut.AddRange(mapper.Map<List<RefFuncionGetDTO>>(entitiesIn));

            if (entitiesOut.Count == 0)
            {
                return Result<RefFuncionDTO>.Failure(entitiesOut, new string[] { "No se encuentran Funciones." });
            }

            return Result<RefFuncionDTO>.Success(entitiesOut, new Paged() {PageCount = unitOfWork.RefFuncionRepository.TotalItems(), PageNumber = refFuncionGetByFilterDTO.PageNumber, PageSize = refFuncionGetByFilterDTO.PageSize });
        }
    }
}
