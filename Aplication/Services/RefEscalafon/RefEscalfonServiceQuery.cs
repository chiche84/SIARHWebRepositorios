using AutoMapper;
using SIARH.Aplication.DTOs;
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

        protected override async Task<List<RefEscalafonDTO>> Filter(RefEscalafonFilter filter)
        {
            IEnumerable<RefEscalafon> entitiesIn = await unitOfWork.RefEscalafonRepository.Filter(filter);

            List<RefEscalafonDTO> entitiesOut = mapper.Map<List<RefEscalafonDTO>>(entitiesIn);

            return entitiesOut;
        }

        public async Task<Result<RefEscalafonDTO>> GetById(int id)
        {
            var refEscalafonDTOs = await Filter(new RefEscalafonFilter() { IdEscalafon = id, EstaActivo = true });

            if (refEscalafonDTOs.Count != 1)
            {
                return Result<RefEscalafonDTO>.Failure(refEscalafonDTOs, new string[] { "No se encuentra Escalafon."});
            }

            return Result<RefEscalafonDTO>.Success(refEscalafonDTOs);
        }

        public async Task<Result<RefEscalafonDTO>> GetByEscalafonDesc(string EscalafonDesc)
        {
            var refEscalafonDTOs = await Filter(new RefEscalafonFilter() { EscalafonDesc = EscalafonDesc, EstaActivo = true });

            if (refEscalafonDTOs.Count == 0)
            {
                return Result<RefEscalafonDTO>.Failure(refEscalafonDTOs, new string[] { "No se encuentra Escalafon." });
            }

            return Result<RefEscalafonDTO>.Success(refEscalafonDTOs);
        }

        public async Task<Result<RefEscalafonDTO>> GetByEscalafonNomenclatura(string EscalafonNomenclatura)
        {
            var refEscalafonDTOs = await Filter(new RefEscalafonFilter() { Nomenclatura = EscalafonNomenclatura, EstaActivo = true });

            if (refEscalafonDTOs.Count == 0)
            {
                return Result<RefEscalafonDTO>.Failure(refEscalafonDTOs, new string[] { "No se encuentra Escalafon." });
            }

            return Result<RefEscalafonDTO>.Success(refEscalafonDTOs);
        }

        public async Task<Result<RefEscalafonDTO>> Get()
        {
            var refEscalafonDTOs = await Filter(new RefEscalafonFilter() { EstaActivo = true });

            if (refEscalafonDTOs.Count == 0)
            {
                return Result<RefEscalafonDTO>.Failure(refEscalafonDTOs, new string[] { "No se encuentran Escalafons." });
            }

            return Result<RefEscalafonDTO>.Success(refEscalafonDTOs);
        }
    }
}
