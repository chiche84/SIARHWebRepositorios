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
        public override async Task<Result<RefEscalafonDTO>> CreatePreConditions(RefEscalafonDTO refEscalafon)
        {
            RefEscalafonCreateDTO refEscalafonCreacion = mapper.Map<RefEscalafonCreateDTO>(refEscalafon);

            List<string> errors = new List<string>();

            try
            {
                //01
                if (refEscalafon == null)
                {
                    errors.Add("El Escalafon no posee Datos.");
                }

                //02
                if (refEscalafon.IdGrupoNivel == null)
                {
                    errors.Add("El Escalafon no posee Grupo Nivel Definido.");
                }

                //03
                var refEscalafonDTOs = await GetByEscalafonDesc(refEscalafonCreacion.EscalafonDesc);
                if (refEscalafonDTOs.Entities.Count > 0)
                {
                    errors.Add($"Un Escalafon con el nombre {refEscalafonCreacion.EscalafonDesc} ya Existe.");
                }

                //04
                refEscalafonDTOs = await GetByEscalafonNomenclatura (refEscalafonCreacion.Nomenclatura);
                if (refEscalafonDTOs.Entities.Count > 0)
                {
                    errors.Add($"Un Escalafon con la nomenclatura {refEscalafonCreacion.Nomenclatura} ya Existe.");
                }
            }
            catch (Exception)
            {
                return Result<RefEscalafonDTO>.Failure(refEscalafon, new string[] { "Excepción en la evaluación de Pre Condiciones" });
                throw;
            }

            if (errors.Count > 0)
            {
                return Result<RefEscalafonDTO>.Failure(refEscalafon, errors.ToArray());
            }

            return Result<RefEscalafonDTO>.Success(refEscalafon);
        }


    }
}
