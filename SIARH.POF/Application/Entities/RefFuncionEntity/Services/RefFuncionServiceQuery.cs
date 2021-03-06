using AutoMapper;
using SIARH.POF.Application.Entities.RefFuncionEntity.Dtos;
using SIARH.POF.Application.Common;
using SIARH.POF.Persistence.Filters;
using SIARH.POF.Persistence.Models;
using SIARH.POF.Persistence.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SIARH.POF.Application.Entities.RefFuncionEntity.Services
{
    public partial class RefFuncionService 
    {

        protected async Task<List<RefFuncionGetDTO>> Filter(RefFuncionFilter filter)
        {
            IEnumerable<RefFuncion> entitiesIn = await unitOfWork.RefFuncionRepository.Filter(filter);

            List<RefFuncionGetDTO> entitiesOut = mapper.Map<List<RefFuncionGetDTO>>(entitiesIn);

            return entitiesOut;
        }

        public override async Task<Result<RefFuncionDTO>> GetById(int id)
        {
            List<RefFuncionDTO> entitiesOut = new List<RefFuncionDTO>();

            entitiesOut.AddRange(await Filter(new RefFuncionFilter() { Id = id, EstaActivo = true }));

            if (entitiesOut.Count != 1)
            {
                return Result<RefFuncionDTO>.Failure(entitiesOut, new string[] { "No se encuentra Escalafon." });
            }

            return Result<RefFuncionDTO>.Success(entitiesOut);
        }

        public async Task<Result<RefFuncionDTO>> GetByEscalafonDesc(string funcionDesc)
        {
            List<RefFuncionDTO> entitiesOut = new List<RefFuncionDTO>();

            entitiesOut.AddRange(await Filter(new RefFuncionFilter() { FuncionDesc = funcionDesc, EstaActivo = true }));

            if (entitiesOut.Count == 0)
            {
                return Result<RefFuncionDTO>.Failure(entitiesOut, new string[] { "No se encuentra Escalafon." });
            }

            return Result<RefFuncionDTO>.Success(entitiesOut);
        }

        public override async Task<Result<RefFuncionDTO>> Get()
        {
            List<RefFuncionDTO> entitiesOut = new List<RefFuncionDTO>();

            entitiesOut.AddRange(await Filter(new RefFuncionFilter() { EstaActivo = true }));

            if (entitiesOut.Count == 0)
            {
                return Result<RefFuncionDTO>.Failure(entitiesOut, new string[] { "No se encuentran Funciones." });
            }

            return Result<RefFuncionDTO>.Success(entitiesOut);
        }
    }
}
