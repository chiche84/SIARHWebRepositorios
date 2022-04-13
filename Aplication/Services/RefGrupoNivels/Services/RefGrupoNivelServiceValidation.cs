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
        public override async Task<Result<RefGrupoNivelDTO>> CreatePreConditions(RefGrupoNivelDTO RefGrupoNivel)
        {
            RefGrupoNivelCreateDTO RefGrupoNivelCreacion = (RefGrupoNivelCreateDTO)RefGrupoNivel;

            List<string> errors = new List<string>();

            try
            {
                //01
                if (RefGrupoNivelCreacion == null)
                {
                    errors.Add("El Escalafon no posee Datos.");
                }


                //03
                var RefGrupoNivelDTOs = await GetByGrupoDesc(RefGrupoNivelCreacion.GrupoDesc);
                if (RefGrupoNivelDTOs.Entities.Count > 0)
                {
                    errors.Add($"Un Escalafon con el nombre {RefGrupoNivelCreacion.GrupoDesc} ya Existe.");
                }

            }
            catch (Exception)
            {
                return Result<RefGrupoNivelDTO>.Failure(RefGrupoNivel, new string[] { "Excepción en la evaluación de Pre Condiciones" });
                throw;
            }

            if (errors.Count > 0)
            {
                return Result<RefGrupoNivelDTO>.Failure(RefGrupoNivel, errors.ToArray());
            }

            return Result<RefGrupoNivelDTO>.Success(RefGrupoNivel);
        }


    }
}
