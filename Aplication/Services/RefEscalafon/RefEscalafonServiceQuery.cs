using AutoMapper;
using SIARH.Aplication.DTOs;
using SIARH.Aplication.DTOs.RefEscalafon;
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
    public partial class RefEscalafonService 
    {

        protected  async Task<List<RefEscalafonGetDTO>> Filter(RefEscalafonFilter filter)
        {
            IEnumerable<RefEscalafon> entitiesIn = await unitOfWork.RefEscalafonRepository.Filter(filter);

            List<RefEscalafonGetDTO> entitiesOut = mapper.Map<List<RefEscalafonGetDTO>>(entitiesIn);

            return entitiesOut;
        }

        public async Task<Result<RefEscalafonDTO>> GetById(int id)
        {
            List<RefEscalafonDTO> entitiesOut = new List<RefEscalafonDTO>();

            entitiesOut.AddRange(await Filter(new RefEscalafonFilter() { IdEscalafon = id, EstaActivo = true }));

            if (entitiesOut.Count != 1)
            {
                return Result<RefEscalafonDTO>.Failure(entitiesOut, new string[] { "No se encuentra Escalafon."});
            }

            return Result<RefEscalafonDTO>.Success(entitiesOut);
        }

        public async Task<Result<RefEscalafonDTO>> GetByEscalafonDesc(string EscalafonDesc)
        {
            List<RefEscalafonDTO> entitiesOut = new List<RefEscalafonDTO>();

            entitiesOut.AddRange(await Filter(new RefEscalafonFilter() { EscalafonDesc = EscalafonDesc, EstaActivo = true }));

            if (entitiesOut.Count == 0)
            {
                return Result<RefEscalafonDTO>.Failure(entitiesOut, new string[] { "No se encuentra Escalafon." });
            }

            return Result<RefEscalafonDTO>.Success(entitiesOut);
        }

        public async Task<Result<RefEscalafonDTO>> GetByEscalafonNomenclatura(string EscalafonNomenclatura)
        {
            List<RefEscalafonDTO> entitiesOut = new List<RefEscalafonDTO>();

            entitiesOut.AddRange(await Filter(new RefEscalafonFilter() { Nomenclatura = EscalafonNomenclatura, EstaActivo = true }));

            if (entitiesOut.Count == 0)
            {
                return Result<RefEscalafonDTO>.Failure(entitiesOut, new string[] { "No se encuentra Escalafon." });
            }

            return Result<RefEscalafonDTO>.Success(entitiesOut);
        }

        public async Task<Result<RefEscalafonDTO>> Get()
        {
            List<RefEscalafonDTO> entitiesOut = new List<RefEscalafonDTO>();

            entitiesOut.AddRange(await Filter(new RefEscalafonFilter() { EstaActivo = true }));

            if (entitiesOut.Count == 0)
            {
                return Result<RefEscalafonDTO>.Failure(entitiesOut, new string[] { "No se encuentran Escalafons." });
            }

            return Result<RefEscalafonDTO>.Success(entitiesOut);
        }
    }
}
