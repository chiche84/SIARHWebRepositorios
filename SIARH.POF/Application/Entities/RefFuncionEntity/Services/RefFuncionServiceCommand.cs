using AutoMapper;
using MediatR;
using SIARH.POF.Application.Entities.RefFuncionEntity.Dtos;
using SIARH.POF.Application.Common;
using SIARH.POF.Persistence.Filters;
using SIARH.POF.Persistence.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using SIARH.POF.Persistence.UnitOfWork;

namespace SIARH.POF.Application.Entities.RefFuncionEntity.Services
{
    public partial class RefFuncionService : GenericService<RefFuncionDTO, RefFuncionFilter>
    {
        private readonly UnitOfWork unitOfWork;
        private readonly IMapper mapper;
        private readonly IMediator mediator;

        public RefFuncionService(UnitOfWork unitOfWork, IMapper mapper, IMediator mediator)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
            this.mediator = mediator;
        }

        public override async Task<Result<RefFuncionDTO>> Create(RefFuncionDTO entityIn)
        {
            try
            {
                Result<RefFuncionDTO> resultPre = CreatePreConditions(entityIn).Result;

                if (resultPre.Succeeded)
                {
                    RefFuncion RefFuncion = mapper.Map<RefFuncion>(entityIn);
                    await unitOfWork.RefFuncionRepository.Create(RefFuncion);

                    Result<RefFuncionDTO> resultPost = CreatePostConditions(entityIn).Result;
                    if (resultPost.Succeeded)
                    {
                        await unitOfWork.CompleteAsync();

                        RefFuncionUpdateDTO entityOut = mapper.Map<RefFuncionUpdateDTO>(RefFuncion);

                        return  Result<RefFuncionDTO>.Success(entityOut);
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
                return Result<RefFuncionDTO>.Failure(entityIn, new List<string>(){"error"});

                //throw;
            }
        }

        public override async Task<Result<RefFuncionDTO>> Update(RefFuncionDTO entityIn)
        {
            try
            {
                Result<RefFuncionDTO> resultPre = UpdatePreConditions(entityIn).Result;

                if (resultPre.Succeeded)
                {
                    RefFuncion RefFuncion = mapper.Map<RefFuncion>(entityIn);
                    await unitOfWork.RefFuncionRepository.Update(RefFuncion);

                    RefFuncionDTO entityOut = mapper.Map<RefFuncionDTO>(RefFuncion);

                    Result<RefFuncionDTO> resultPost = UpdatePostConditions(entityOut).Result;
                    if (resultPost.Succeeded)
                    {
                        await unitOfWork.CompleteAsync();

                        return Result<RefFuncionDTO>.Success(entityOut);
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
                return Result<RefFuncionDTO>.Failure(entityIn, new List<string>() { "error" });

                //throw;

            }
        }

        public override async Task<Result<RefFuncionDTO>> Delete(RefFuncionDTO entityIn)
        {
            try
            {
                Result<RefFuncionDTO> resultPre = DeletePreConditions(entityIn).Result;

                if (resultPre.Succeeded)
                {
                    RefFuncion RefFuncion = mapper.Map<RefFuncion>(entityIn);
                    bool deleted = await unitOfWork.RefFuncionRepository.Delete(RefFuncion.IdFuncion);

                    if (deleted)
                    {
                        Result<RefFuncionDTO> resultPost = DeletePostConditions(entityIn).Result;
                        if (resultPost.Succeeded)
                        {
                            await unitOfWork.CompleteAsync();

                            return Result<RefFuncionDTO>.Success(entityIn);
                        }
                        else
                        {
                            return resultPost;
                        }
                    }
                    else
                    {
                        return Result<RefFuncionDTO>.Failure(entityIn, new[] { "DB Error al Intentar Eliminar el Escalafon." });
                    }
                }
                else
                {
                    return resultPre;
                }
            }
            catch (Exception)
            {
                return Result<RefFuncionDTO>.Failure(entityIn, new List<string>() { "error" });

                //throw;

            }
        }

    
    }
}
