using AutoMapper;
using Me.Siarh.Common.Application;
using Me.Siarh.Pof.Application.RefFuncionEntity.Dtos;
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
        public override async Task<Result<RefFuncionDTO>> CreatePreConditions(RefFuncionDTO RefFuncion)
        {
            RefFuncionCreateDTO RefFuncionCreacion = (RefFuncionCreateDTO)RefFuncion;

            List<string> errors = new List<string>();

            try
            {
                //01
                if (RefFuncionCreacion == null)
                {
                    errors.Add("La Función no posee Datos.");
                }

                //02
                if (string.IsNullOrWhiteSpace(RefFuncionCreacion.FuncionDesc))
                {
                    errors.Add("La Función debe poseer un Nombre Válido.");
                }

                //03
                var RefFuncionDtos = await GetByFilter(new RefFuncionGetByFilterDTO() {FuncionDescContains = RefFuncionCreacion.FuncionDesc });
                if (RefFuncionDtos.Entities.Count > 0)
                {
                    errors.Add($"Un Escalafon con el nombre {RefFuncionCreacion.FuncionDesc} ya Existe.");
                }

            }
            catch (Exception)
            {
                return Result<RefFuncionDTO>.Failure(RefFuncion, new string[] { "Excepción en la evaluación de Pre Condiciones" });
                throw;
            }

            if (errors.Count > 0)
            {
                return Result<RefFuncionDTO>.Failure(RefFuncion, errors.ToArray());
            }

            return Result<RefFuncionDTO>.Success(RefFuncion);
        }

        public override async Task<Result<RefFuncionDTO>> UpdatePreConditions(RefFuncionDTO RefFuncion)
        {
            RefFuncionUpdateDTO refFuncionUpdateDTO = (RefFuncionUpdateDTO)RefFuncion;

            List<string> errors = new List<string>();

            try
            {
                //01
                if (refFuncionUpdateDTO == null)
                {
                    errors.Add("La Función no posee Datos.");
                }

                //01
                var response = await GetById(refFuncionUpdateDTO.Id);
                if (!response.Succeeded)
                {
                    errors.Add($"No Existe la Función {refFuncionUpdateDTO.FuncionDesc}.");
                }

                //02
                if (string.IsNullOrWhiteSpace(refFuncionUpdateDTO.FuncionDesc))
                {
                    errors.Add("La Función debe poseer un Nombre Válido.");
                }

                //03
                var RefFuncionDtos = await GetByFilter(new RefFuncionGetByFilterDTO() { FuncionDesc = refFuncionUpdateDTO.FuncionDesc, ExcludeIds = new List<int>() {refFuncionUpdateDTO.Id }, EstaActivo = true });
                if (RefFuncionDtos.Succeeded)
                {
                    errors.Add($"Una Función con el nombre {refFuncionUpdateDTO.FuncionDesc} ya Existe.");
                }

            }
            catch (Exception)
            {
                return Result<RefFuncionDTO>.Failure(RefFuncion, new string[] { "Excepción en la evaluación de Pre Condiciones" });
                throw;
            }

            if (errors.Count > 0)
            {
                return Result<RefFuncionDTO>.Failure(RefFuncion, errors.ToArray());
            }

            return Result<RefFuncionDTO>.Success(RefFuncion);
        }


    }
}
