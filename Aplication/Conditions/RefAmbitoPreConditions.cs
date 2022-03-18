using SIARH.Aplication.DTOs;
using SIARH.Aplication.Interfaces;
using SIARH.Aplication.Models;
using SIARH.Persistence.Filters;
using SIARH.Persistence.Models;
using SIARH.Persistence.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIARH.Aplication.Conditions
{
    internal class RefAmbitoPreConditions: GenericPreConditions<RefAmbito, IRefAmbitoDTO >, IPreConditions<RefAmbito, IRefAmbitoDTO>
    {
        private readonly IUnitOfWork unitOfWork;

        public RefAmbitoPreConditions(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public override async Task<Result<IRefAmbitoDTO>> IsValid(RefAmbito refAmbito)
        {
            List<string> errors = new List<string>();

            try
            {
                if (refAmbito == null)
                {
                    errors.Add("El Ambito no posee Datos.");
                }

                bool exist = unitOfWork.RefAmbitoRepository.Filter(new RefAmbitoFilter() { AmbitoDesc = refAmbito.AmbitoDesc}).Result.
                if (true)
                {

                }
            }
            catch (Exception)
            {
                return Result<IRefAmbitoDTO>.Failure(new string[] { "Excepción en la evaluación de Pre Condiciones" });
                throw;
            }

            if (errors.Count > 0)
            {
                return Result<IRefAmbitoDTO>.Failure(errors.ToArray());
            }                                                                                                          

            return Result<IRefAmbitoDTO>.Success();
        }
    }
}
