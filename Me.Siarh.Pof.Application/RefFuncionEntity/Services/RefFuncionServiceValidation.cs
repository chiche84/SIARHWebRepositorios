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

                //03
                var RefFuncionDtos = await GetByEscalafonDesc(RefFuncionCreacion.FuncionDesc);
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


    }
}
