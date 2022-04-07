using AutoMapper;
using Microsoft.Extensions.Logging;

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
    public partial class RefAmbitoService : GenericService<RefAmbitoDTO, RefAmbitoFilter>, IService<RefAmbitoDTO, RefAmbitoFilter>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;
        private readonly ILogger<RefAmbitoService> logger;

        public RefAmbitoService(IUnitOfWork unitOfWork, IMapper mapper, ILogger<RefAmbitoService> logger)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
            this.logger = logger;
        }

        public async Task<Result<RefAmbitoDTO>> Create(RefAmbitoDTO entityIn)
        {
            try
            {
                Result<RefAmbitoDTO> resultPre = CreatePreConditions(entityIn).Result;

                if (resultPre.Succeeded)
                {
                    RefAmbito refAmbito = mapper.Map<RefAmbito>(entityIn);

                    logger.LogInformation("Guardando Ref Ambito");

                    await unitOfWork.RefAmbitoRepository.Create(refAmbito);

                    Result<RefAmbitoDTO> resultPost = CreatePostConditions(entityIn).Result;
                    if (resultPost.Succeeded)
                    {

                        RefAmbitoUpdateDTO entityOut = mapper.Map<RefAmbitoUpdateDTO>(refAmbito);

                        var response =  Result<RefAmbitoDTO>.Success(entityOut);

                        return response;
                    }
                    else
                    {
                        return resultPost;
                    }
                }
                else
                {
                    return resultPre;
                }
            }
            catch (Exception)
            {
                return Result<RefAmbitoDTO>.Failure(entityIn, new List<string>(){"error"});
                //throw;
            }
        }

        public async Task<Result<RefAmbitoDTO>> Update(RefAmbitoDTO entityIn)
        {
            try
            {
                Result<RefAmbitoDTO> resultPre = UpdatePreConditions(entityIn).Result;

                if (resultPre.Succeeded)
                {
                    RefAmbito refAmbito = mapper.Map<RefAmbito>(entityIn);
                    await unitOfWork.RefAmbitoRepository.Update(refAmbito);

                    RefAmbitoDTO entityOut = mapper.Map<RefAmbitoDTO>(refAmbito);

                    Result<RefAmbitoDTO> resultPost = UpdatePostConditions(entityOut).Result;
                    if (resultPost.Succeeded)
                    {
                        await unitOfWork.CompleteAsync();

                        return Result<RefAmbitoDTO>.Success(entityOut);
                    }
                    else
                    {
                        return resultPost;
                    }
                }
                else
                {
                    return resultPre;
                }
            }
            catch (Exception)
            {
                return Result<RefAmbitoDTO>.Failure(entityIn, new List<string>() { "error" });

                //throw;

            }
        }

        public async Task<Result<RefAmbitoDTO>> Delete(RefAmbitoDTO entityIn)
        {
            try
            {
                Result<RefAmbitoDTO> resultPre = DeletePreConditions(entityIn).Result;

                if (resultPre.Succeeded)
                {
                    RefAmbito refAmbito = mapper.Map<RefAmbito>(entityIn);
                    bool deleted = await unitOfWork.RefAmbitoRepository.Delete(refAmbito.IdAmbito);

                    if (deleted)
                    {
                        Result<RefAmbitoDTO> resultPost = DeletePostConditions(entityIn).Result;
                        if (resultPost.Succeeded)
                        {
                            await unitOfWork.CompleteAsync();

                            return Result<RefAmbitoDTO>.Success(entityIn);
                        }
                        else
                        {
                            return resultPost;
                        }
                    }
                    else
                    {
                        return Result<RefAmbitoDTO>.Failure(entityIn, new[] { "DB Error al Intentar Eliminar el Ambito." });
                    }
                }
                else
                {
                    return resultPre;
                }
            }
            catch (Exception)
            {
                return Result<RefAmbitoDTO>.Failure(entityIn, new List<string>() { "error" });

                //throw;

            }
        }

    
    }
}
