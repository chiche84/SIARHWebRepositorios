﻿using AutoMapper;
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
    public partial class RefAmbitoService 
    {

        protected override async Task<List<RefAmbitoDTO>> Filter(RefAmbitoFilter filter)
        {
            IEnumerable<RefAmbito> entitiesIn = await unitOfWork.RefAmbitoRepository.Filter(filter);

            List<RefAmbitoDTO> entitiesOut = mapper.Map<List<RefAmbitoDTO>>(entitiesIn);

            return entitiesOut;
        }

        public async Task<Result<RefAmbitoDTO>> GetById(int id)
        {
            var refAmbitoDTOs = await Filter(new RefAmbitoFilter() { IdAmbito = id, EstaActivo = true });

            if (refAmbitoDTOs.Count != 1)
            {
                return Result<RefAmbitoDTO>.Failure(refAmbitoDTOs, new string[] { "No se encuentra Ambito."});
            }

            return Result<RefAmbitoDTO>.Success(refAmbitoDTOs);
        }

        public async Task<Result<RefAmbitoDTO>> GetByAmbitoDesc(string ambitoDesc)
        {
            var refAmbitoDTOs = await Filter(new RefAmbitoFilter() { AmbitoDesc = ambitoDesc, EstaActivo = true });

            if (refAmbitoDTOs.Count == 0)
            {
                return Result<RefAmbitoDTO>.Failure(refAmbitoDTOs, new string[] { "No se encuentra Ambito." });
            }

            return Result<RefAmbitoDTO>.Success(refAmbitoDTOs);
        }

        public async Task<Result<RefAmbitoDTO>> Get()
        {
            var refAmbitoDTOs = await Filter(new RefAmbitoFilter() { EstaActivo = true });

            if (refAmbitoDTOs.Count == 0)
            {
                return Result<RefAmbitoDTO>.Failure(refAmbitoDTOs, new string[] { "No se encuentran Ambitos." });
            }

            return Result<RefAmbitoDTO>.Success(refAmbitoDTOs);
        }
    }
}