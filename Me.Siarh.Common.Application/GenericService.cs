
using AutoMapper;
using Me.Siarh.Common.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Me.Siarh.Common.Application
{
    public abstract class GenericService<T, U, V, X, W, Y> : IGenericService<T, U>
                              where T : IDTO                      //dtoEntityIn
                              where U : GenericFilter, IFilterDTO //dtoFilter
                              where V : IGenericRepository<X, W>   //dataRepository
                              where X : class                     //dataEntity
                              where Y : T                          //dtoEntityOut
                              where W : GenericFilter, new()      //dataFilter
    {
        private readonly IMapper mapper;
        private readonly IGenericRepository<X, W> dataRepository;

        public GenericService(IMapper mapper, IGenericRepository<X, W> repository)
        {
            this.mapper = mapper;
            this.dataRepository = repository;
        }

        public virtual async Task<Result<T>> Create(T dtoEntityIn)
        {
            try
            {
                Result<T> resultPre = CreatePreConditions(dtoEntityIn).Result;

                if (resultPre.Succeeded)
                {
                    X dataEntity = mapper.Map<X>(dtoEntityIn);
                    await dataRepository.Create(dataEntity);

                    Result<T> resultPost = CreatePostConditions(dtoEntityIn).Result;
                    if (resultPost.Succeeded)
                    {
                        Y dtoEntityOut = mapper.Map<Y>(dataEntity);

                        return Result<T>.Success(dtoEntityOut);
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
                return Result<T>.Failure(dtoEntityIn, new List<string>() { "error" });
            }
        }

        public virtual async Task<Result<T>> Update(T dtoEntityIn)
        {
            try
            {
                Result<T> resultPre = UpdatePreConditions(dtoEntityIn).Result;

                if (resultPre.Succeeded)
                {
                    X dataEntity = mapper.Map<X>(dtoEntityIn);
                    await dataRepository.Update(dataEntity);

                    T dtoEntityOut = mapper.Map<T>(dataEntity);

                    Result<T> resultPost = UpdatePostConditions(dtoEntityOut).Result;
                    if (resultPost.Succeeded)
                    {
                        return Result<T>.Success(dtoEntityOut);
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
                return Result<T>.Failure(dtoEntityIn, new List<string>() { "error" });
            }
        }

        public virtual async Task<Result<T>> Delete(T dtoEntityIn)
        {
            try
            {
                Result<T> resultPre = DeletePreConditions(dtoEntityIn).Result;

                if (resultPre.Succeeded)
                {
                    X dataEntity = mapper.Map<X>(dtoEntityIn);
                    bool deleted = await dataRepository.Delete(dataEntity);

                    if (deleted)
                    {
                        Result<T> resultPost = DeletePostConditions(dtoEntityIn).Result;
                        if (resultPost.Succeeded)
                        {
                            return Result<T>.Success(dtoEntityIn);
                        }
                        else
                        {
                            return resultPost;
                        }
                    }
                    else
                    {
                        return Result<T>.Failure(dtoEntityIn, new[] { "DB Error al Intentar Eliminar el Escalafon." });
                    }
                }
                else
                {
                    return resultPre;
                }
            }
            catch (Exception)
            {
                return Result<T>.Failure(dtoEntityIn, new List<string>() { "error" });

                //throw;

            }
        }

        public virtual async Task<Result<T>> GetById(int id)
        {

            List<T> dtoEntitiesOut = new List<T>();

            IEnumerable<X> dataEntities = await dataRepository.FilterPaginated(new W() { Id = id, EstaActivo = true });

            dtoEntitiesOut.AddRange((IEnumerable<T>)mapper.Map<List<Y>>(dataEntities));

            if (dtoEntitiesOut.Count != 1)
            {
                return Result<T>.Failure(dtoEntitiesOut, new string[] { "No se encuentra Escalafon." });
            }

            return Result<T>.Success(dtoEntitiesOut.Single());
        }

        public async Task<Result<T>> GetByFilter(U dtoFilter)
        {
            List<T> dtoEntitiesOutOut = new List<T>();

            IEnumerable<X> dtoEntitiesOutIn = await dataRepository.FilterPaginated(mapper.Map<W>(dtoFilter));

            dtoEntitiesOutOut.AddRange((IEnumerable<T>)mapper.Map<List<Y>>(dtoEntitiesOutIn));

            if (dtoEntitiesOutOut.Count == 0)
            {
                return Result<T>.Failure(dtoEntitiesOutOut, new string[] { "No se encuentran Funciones." });
            }

            return Result<T>.Success(dtoEntitiesOutOut, new Paged() { PageCount = dataRepository.TotalItems(), PageNumber = dtoFilter.PageNumber, PageSize = dtoFilter.PageSize });
        }

        public virtual async Task<Result<T>> CreatePostConditions(T dtoEntityIn)
        {
            List<T> dtoEntitiesOut = new List<T>();
            dtoEntitiesOut.Add(dtoEntityIn);
            return Result<T>.Success(dtoEntitiesOut);
        }

        public virtual async Task<Result<T>> CreatePreConditions(T dtoEntityIn)
        {
            List<T> dtoEntitiesOut = new List<T>();
            dtoEntitiesOut.Add(dtoEntityIn);
            return Result<T>.Success(dtoEntitiesOut);
        }

        public virtual async Task<Result<T>> UpdatePreConditions(T dtoEntityIn)
        {
            List<T> dtoEntitiesOut = new List<T>();
            dtoEntitiesOut.Add(dtoEntityIn);
            return Result<T>.Success(dtoEntitiesOut);
        }

        public virtual async Task<Result<T>> UpdatePostConditions(T dtoEntityIn)
        {
            List<T> dtoEntitiesOut = new List<T>();
            dtoEntitiesOut.Add(dtoEntityIn);
            return Result<T>.Success(dtoEntitiesOut);
        }

        public virtual async Task<Result<T>> DeletePreConditions(T dtoEntityIn)
        {
            List<T> dtoEntitiesOut = new List<T>();
            dtoEntitiesOut.Add(dtoEntityIn);
            return Result<T>.Success(dtoEntitiesOut);
        }

        public virtual async Task<Result<T>> DeletePostConditions(T dtoEntityIn)
        {
            List<T> dtoEntitiesOut = new List<T>();
            dtoEntitiesOut.Add(dtoEntityIn);
            return Result<T>.Success(dtoEntitiesOut);
        }


    }
}
