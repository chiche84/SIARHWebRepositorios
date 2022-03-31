using AutoMapper;
using SIARH.Aplication.DTOs;
using SIARH.Aplication.DTOs.RefAmbito;
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
    public partial class RefAmbitoService 
    {

        protected async Task<List<RefAmbitoGetDTO>> Filter(RefAmbitoFilter filter)
        {
            IEnumerable<RefAmbito> entitiesIn = await unitOfWork.RefAmbitoRepository.Filter(filter);

            List<RefAmbitoGetDTO> entitiesOut = mapper.Map<List<RefAmbitoGetDTO>>(entitiesIn);

            return entitiesOut;
        }

        public async Task<Result<RefAmbitoDTO>> GetById(int id)
        {
            List<RefAmbitoDTO> entitiesOut = new List<RefAmbitoDTO>();

            entitiesOut.AddRange( await Filter(new RefAmbitoFilter() { IdAmbito = id, EstaActivo = true }));

            if (entitiesOut.Count != 1)
            {
                return Result<RefAmbitoDTO>.Failure(entitiesOut, new string[] { "No se encuentra Ambito."});
            }

            return Result<RefAmbitoDTO>.Success(entitiesOut);
        }

        public async Task<Result<RefAmbitoDTO>> GetByAmbitoDesc(string ambitoDesc)
        {
            List<RefAmbitoDTO> entitiesOut = new List<RefAmbitoDTO>();

            entitiesOut.AddRange(await Filter(new RefAmbitoFilter() { AmbitoDesc = ambitoDesc, EstaActivo = true }));

            if (entitiesOut.Count == 0)
            {
                return Result<RefAmbitoDTO>.Failure(entitiesOut, new string[] { "No se encuentra Ambito." });
            }

            return Result<RefAmbitoDTO>.Success(entitiesOut);
        }

        public async Task<Result<RefAmbitoDTO>> Get()
        {
            List<RefAmbitoDTO> entitiesOut = new List<RefAmbitoDTO>();

            entitiesOut.AddRange(await Filter(new RefAmbitoFilter() { EstaActivo = true }));

            if (entitiesOut.Count == 0)
            {
                return Result<RefAmbitoDTO>.Failure(entitiesOut, new string[] { "No se encuentran Ambitos." });
            }

            return Result<RefAmbitoDTO>.Success(entitiesOut);
        }
    }
}
