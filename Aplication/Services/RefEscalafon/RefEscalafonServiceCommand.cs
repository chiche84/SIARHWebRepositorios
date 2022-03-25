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
    public partial class RefEscalafonService : GenericService<RefEscalafonDTO, RefEscalafonFilter>, IService<RefEscalafonDTO, RefEscalafonFilter>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public RefEscalafonService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;        

        }

        public async Task<Result<RefEscalafonDTO>> Create(RefEscalafonDTO entityIn)
        {
            try
            {
                entityIn.EstaActivo = true;
                Result<RefEscalafonDTO> resultPre = CreatePreConditions(entityIn).Result;

                if (resultPre.Succeeded)
                {
                    RefEscalafon refEscalafon = mapper.Map<RefEscalafon>(entityIn);
                    await unitOfWork.RefEscalafonRepository.Create(refEscalafon);

                    Result<RefEscalafonDTO> resultPost = CreatePostConditions(entityIn).Result;
                    if (resultPost.Succeeded)
                    {
                        await unitOfWork.CompleteAsync();

                        RefEscalafonDTO entityOut = mapper.Map<RefEscalafonDTO>(refEscalafon);

                        return  Result<RefEscalafonDTO>.Success(entityOut);
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
                return Result<RefEscalafonDTO>.Failure(entityIn, new List<string>(){"error"});

                //throw;
            }
        }

        public async Task<Result<RefEscalafonDTO>> Update(RefEscalafonDTO entityIn)
        {
            try
            {
                entityIn.EstaActivo = true;
                Result<RefEscalafonDTO> resultPre = UpdatePreConditions(entityIn).Result;

                if (resultPre.Succeeded)
                {
                    RefEscalafon refEscalafon = mapper.Map<RefEscalafon>(entityIn);
                    await unitOfWork.RefEscalafonRepository.Update(refEscalafon);

                    RefEscalafonDTO entityOut = mapper.Map<RefEscalafonDTO>(refEscalafon);

                    Result<RefEscalafonDTO> resultPost = UpdatePostConditions(entityOut).Result;
                    if (resultPost.Succeeded)
                    {
                        await unitOfWork.CompleteAsync();

                        return Result<RefEscalafonDTO>.Success(entityOut);
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
                return Result<RefEscalafonDTO>.Failure(entityIn, new List<string>() { "error" });

                //throw;

            }
        }

        public async Task<Result<RefEscalafonDTO>> Delete(RefEscalafonDTO entityIn)
        {
            try
            {
                entityIn.EstaActivo = true;
                Result<RefEscalafonDTO> resultPre = DeletePreConditions(entityIn).Result;

                if (resultPre.Succeeded)
                {
                    RefEscalafon refEscalafon = mapper.Map<RefEscalafon>(entityIn);
                    bool deleted = await unitOfWork.RefEscalafonRepository.Delete(refEscalafon.IdEscalafon);

                    if (deleted)
                    {
                        Result<RefEscalafonDTO> resultPost = DeletePostConditions(entityIn).Result;
                        if (resultPost.Succeeded)
                        {
                            await unitOfWork.CompleteAsync();

                            return Result<RefEscalafonDTO>.Success(entityIn);
                        }
                        else
                        {
                            return resultPost;
                        }
                    }
                    else
                    {
                        return Result<RefEscalafonDTO>.Failure(entityIn, new[] { "DB Error al Intentar Eliminar el Escalafon." });
                    }
                }
                else
                {
                    return resultPre;
                }
            }
            catch (Exception)
            {
                return Result<RefEscalafonDTO>.Failure(entityIn, new List<string>() { "error" });

                //throw;

            }
        }

    
    }
}
