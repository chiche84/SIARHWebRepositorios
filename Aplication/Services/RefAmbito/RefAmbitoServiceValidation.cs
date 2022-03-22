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
    public partial class RefAmbitoService : GenericService<RefAmbitoDTO, RefAmbitoFilter>
    {
        public override async Task<Result<RefAmbitoDTO>> CreatePreConditions(RefAmbitoDTO refAmbito)
        {
            RefAmbitoCreateDTO refAmbitoCreacion = (RefAmbitoCreateDTO)refAmbito;

            List<string> errors = new List<string>();

            try
            {
                //01
                if (refAmbito == null)
                {
                    errors.Add("El Ambito no posee Datos.");
                }

                //02
                var refAmbitoDTOs = await GetByAmbitoDesc(refAmbitoCreacion.AmbitoDesc);
                if (refAmbitoDTOs.Entities.Count > 0)
                {
                    errors.Add("El Ambito ya Existe.");
                }
            }
            catch (Exception)
            {
                return Result<RefAmbitoDTO>.Failure(refAmbito, new string[] { "Excepción en la evaluación de Pre Condiciones" });
                throw;
            }

            if (errors.Count > 0)
            {
                return Result<RefAmbitoDTO>.Failure(refAmbito, errors.ToArray());
            }

            return Result<RefAmbitoDTO>.Success(refAmbito);
        }


    }
}
