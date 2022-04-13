using AutoMapper;
using SIARH.Aplication.DTOs;
using SIARH.Aplication.Services.RefGrupoNivels.Dtos;
using SIARH.Aplication.Interfaces;
using SIARH.Aplication.Models;
using SIARH.Persistence.Filters;
using SIARH.Persistence.Models;
using SIARH.Persistence.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SIARH.Aplication.Services
{
    public partial class RefGrupoNivelService 
    {

        protected  async Task<List<RefGrupoNivelGetDTO>> Filter(RefGrupoNivelFilter filter)
        {
            IEnumerable<RefGrupoNivel> entitiesIn = await unitOfWork.RefGrupoNivelRepository.Filter(filter);

            List<RefGrupoNivelGetDTO> entitiesOut = mapper.Map<List<RefGrupoNivelGetDTO>>(entitiesIn);

            return entitiesOut;
        }

        public async Task<Result<RefGrupoNivelDTO>> GetById(int id)
        {
            List<RefGrupoNivelDTO> entitiesOut = new List<RefGrupoNivelDTO>();

            entitiesOut.AddRange(await Filter(new RefGrupoNivelFilter() { IdGrupoNivel = id, EstaActivo = true }));

            if (entitiesOut.Count != 1)
            {
                return Result<RefGrupoNivelDTO>.Failure(entitiesOut, new string[] { "No se encuentra Escalafon."});
            }

            return Result<RefGrupoNivelDTO>.Success(entitiesOut);
        }

        public async Task<Result<RefGrupoNivelDTO>> GetByGrupoDesc(string GrupoDesc)
        {
            List<RefGrupoNivelDTO> entitiesOut = new List<RefGrupoNivelDTO>();

            entitiesOut.AddRange(await Filter(new RefGrupoNivelFilter() { GrupoDesc = GrupoDesc, EstaActivo = true }));

            if (entitiesOut.Count == 0)
            {
                return Result<RefGrupoNivelDTO>.Failure(entitiesOut, new string[] { "No se encuentra Escalafon." });
            }

            return Result<RefGrupoNivelDTO>.Success(entitiesOut);
        }

        public async Task<Result<RefGrupoNivelDTO>> Get()
        {
            List<RefGrupoNivelDTO> entitiesOut = new List<RefGrupoNivelDTO>();

            entitiesOut.AddRange(await Filter(new RefGrupoNivelFilter() { EstaActivo = true }));

            if (entitiesOut.Count == 0)
            {
                return Result<RefGrupoNivelDTO>.Failure(entitiesOut, new string[] { "No se encuentran Escalafons." });
            }

            return Result<RefGrupoNivelDTO>.Success(entitiesOut);
        }
    }
}
