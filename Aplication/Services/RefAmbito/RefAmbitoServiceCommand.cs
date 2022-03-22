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
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public RefAmbitoService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;        

        }

        public override async Task<Result<RefAmbitoDTO>> Create(RefAmbitoDTO entityIn)
        {
            try
            {
                Result<RefAmbitoDTO> resultPre = CreatePreConditions(entityIn).Result;

                if (resultPre.Succeeded)
                {
                    RefAmbito refAmbito = mapper.Map<RefAmbito>(entityIn);
                    await unitOfWork.RefAmbitoRepository.Create(refAmbito);

                    RefAmbitoUpdateDTO entityOut = mapper.Map<RefAmbitoUpdateDTO>(refAmbito);
                    
                    Result<RefAmbitoDTO> resultPost = CreatePostConditions(entityOut).Result;
                    if (resultPost.Succeeded)
                    {
                        await unitOfWork.CompleteAsync();

                        return  Result<RefAmbitoDTO>.Success(entityOut);
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

        public Task<Result<RefAmbitoDTO>> Update(RefAmbitoDTO entity)
        {
            throw new NotImplementedException();
        }

        public Task<Result<RefAmbitoDTO>> Delete(int id)
        {
            throw new NotImplementedException();
        }

       

    }
}
