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
    public partial class RefGrupoNivelService : GenericService<RefGrupoNivelDTO, RefGrupoNivelFilter>, IService<RefGrupoNivelDTO, RefGrupoNivelFilter>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public RefGrupoNivelService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;        

        }

        public async Task<Result<RefGrupoNivelDTO>> Create(RefGrupoNivelDTO entityIn)
        {
            try
            {
                Result<RefGrupoNivelDTO> resultPre = CreatePreConditions(entityIn).Result;

                if (resultPre.Succeeded)
                {
                    RefGrupoNivel RefGrupoNivel = mapper.Map<RefGrupoNivel>(entityIn);
                    await unitOfWork.RefGrupoNivelRepository.Create(RefGrupoNivel);

                    Result<RefGrupoNivelDTO> resultPost = CreatePostConditions(entityIn).Result;
                    if (resultPost.Succeeded)
                    {
                        await unitOfWork.CompleteAsync();

                        RefGrupoNivelUpdateDTO entityOut = mapper.Map<RefGrupoNivelUpdateDTO>(RefGrupoNivel);

                        return  Result<RefGrupoNivelDTO>.Success(entityOut);
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
                return Result<RefGrupoNivelDTO>.Failure(entityIn, new List<string>(){"error"});

                //throw;
            }
        }

        public async Task<Result<RefGrupoNivelDTO>> Update(RefGrupoNivelDTO entityIn)
        {
            try
            {
                Result<RefGrupoNivelDTO> resultPre = UpdatePreConditions(entityIn).Result;

                if (resultPre.Succeeded)
                {
                    RefGrupoNivel RefGrupoNivel = mapper.Map<RefGrupoNivel>(entityIn);
                    await unitOfWork.RefGrupoNivelRepository.Update(RefGrupoNivel);

                    RefGrupoNivelDTO entityOut = mapper.Map<RefGrupoNivelDTO>(RefGrupoNivel);

                    Result<RefGrupoNivelDTO> resultPost = UpdatePostConditions(entityOut).Result;
                    if (resultPost.Succeeded)
                    {
                        await unitOfWork.CompleteAsync();

                        return Result<RefGrupoNivelDTO>.Success(entityOut);
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
                return Result<RefGrupoNivelDTO>.Failure(entityIn, new List<string>() { "error" });

                //throw;

            }
        }

        public async Task<Result<RefGrupoNivelDTO>> Delete(RefGrupoNivelDTO entityIn)
        {
            try
            {
                Result<RefGrupoNivelDTO> resultPre = DeletePreConditions(entityIn).Result;

                if (resultPre.Succeeded)
                {
                    RefGrupoNivel RefGrupoNivel = mapper.Map<RefGrupoNivel>(entityIn);
                    bool deleted = await unitOfWork.RefGrupoNivelRepository.Delete(RefGrupoNivel.IdGrupoNivel);

                    if (deleted)
                    {
                        Result<RefGrupoNivelDTO> resultPost = DeletePostConditions(entityIn).Result;
                        if (resultPost.Succeeded)
                        {
                            await unitOfWork.CompleteAsync();

                            return Result<RefGrupoNivelDTO>.Success(entityIn);
                        }
                        else
                        {
                            return resultPost;
                        }
                    }
                    else
                    {
                        return Result<RefGrupoNivelDTO>.Failure(entityIn, new[] { "DB Error al Intentar Eliminar el Escalafon." });
                    }
                }
                else
                {
                    return resultPre;
                }
            }
            catch (Exception)
            {
                return Result<RefGrupoNivelDTO>.Failure(entityIn, new List<string>() { "error" });

                //throw;

            }
        }

    
    }
}
