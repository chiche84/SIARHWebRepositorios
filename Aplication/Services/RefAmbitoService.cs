using AutoMapper;
using SIARH.Aplication.Conditions;
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
    public class RefAmbitoService : GenericService<IRefAmbitoDTO, RefAmbitoFilter>, IService<IRefAmbitoDTO, RefAmbitoFilter>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public RefAmbitoService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;        

        }

        public override async Task<Result<IRefAmbitoDTO>> Add(IRefAmbitoDTO entityIn)
        {
            RefAmbito refAmbito = mapper.Map<RefAmbito>(entityIn);
            List<IRefAmbitoDTO> lista = new List<IRefAmbitoDTO>();

            RefAmbitoPreConditions preconditions = new RefAmbitoPreConditions();
            RefAmbitoPostConditions postconditions = new RefAmbitoPostConditions();

            try
            {
                Result<IRefAmbitoDTO> resultPre = preconditions.IsValid(refAmbito).Result;

                if (resultPre.Succeeded)
                {
                    await unitOfWork.RefAmbitoRepository.Add(refAmbito);

                    Result<IRefAmbitoDTO> resultPost = postconditions.IsValid(refAmbito).Result;

                    if (resultPost.Succeeded)
                    {
                        await unitOfWork.CompleteAsync();

                        List<RefAmbitoEdicionDTO> entityOut = mapper.Map<List<RefAmbitoEdicionDTO>>(refAmbito);
                        lista.AddRange(entityOut);

                        return Result<IRefAmbitoDTO>.Success(lista);
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
                return Result<IRefAmbitoDTO>.Failure(lista, new List<string>(){"error"});

                //throw;

            }
        }


        public Task<Result<IRefAmbitoDTO>> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public override async Task<Result<IRefAmbitoDTO>> Filter(RefAmbitoFilter filter)
        {
            List<IRefAmbitoDTO> lista = new List<IRefAmbitoDTO>();

            IEnumerable<RefAmbito> entities = await unitOfWork.RefAmbitoRepository.Filter(filter);

            RefAmbitoEdicionDTO entityOut = mapper.Map<RefAmbitoEdicionDTO>(entities.FirstOrDefault());

            lista.Add(entityOut);


            var x = Result<IRefAmbitoDTO>.Failure(lista, new string[] {"error", "error2"});

            return x;

        }

        public Task<Result<IRefAmbitoDTO>> Find(Expression<Func<IRefAmbitoDTO, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<IRefAmbitoDTO> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Result<IRefAmbitoDTO>> Upsert(IRefAmbitoDTO entity)
        {
            throw new NotImplementedException();
        }


        //public async Task<IEnumerable<RefAmbito>> Filter(RefAmbitoFilter filter)
        //{
        //    return await unitOfWork.RefAmbitoRepository.Filter(filter);
        //}

        //public async Task<RefAmbito> Add(RefAmbitoCreacionDTO refAmbitoCreacionDTO)
        //{          
        //    RefAmbito refAmbito = mapper.Map<RefAmbito>(refAmbitoCreacionDTO);            
        //    await unitOfWork.RefAmbitoRepository.Add(refAmbito);
        //    await unitOfWork.CompleteAsync();
        //    return refAmbito;
        //}

        //public async Task<RefAmbito> Upsert(RefAmbitoCreacionDTO refAmbitoCreacionDTO)
        //{
        //    RefAmbito refAmbito = mapper.Map<RefAmbito>(refAmbitoCreacionDTO);
        //    await unitOfWork.RefAmbitoRepository.Upsert(refAmbito);            
        //    await unitOfWork.CompleteAsync();
        //    return refAmbito;
        //}

        //public async Task<bool> Delete(int id)
        //{
        //    var refAmbito = await unitOfWork.RefAmbitoRepository.Delete(id);
        //    await unitOfWork.CompleteAsync();
        //    return refAmbito;
        //}

        //public Task<RefAmbitoCreacionDTO> GetById(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //Task<IRefAmbitoDTO> IServicio<IRefAmbitoDTO, RefAmbitoFilter>.GetById(int id)
        //{
        //    throw new NotImplementedException();
        //}



        //Task<Result<IRefAmbitoDTO>> IServicio<IRefAmbitoDTO, RefAmbitoFilter>.Delete(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<Result<IRefAmbitoDTO>> Upsert(IRefAmbitoDTO entity)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<Result<IRefAmbitoDTO>> Find(Expression<Func<IRefAmbitoDTO, bool>> predicate)
        //{
        //    throw new NotImplementedException();
        //}





        //#region METODOS
        //public object Search(string pName, bool? pActivo)
        //{

        //    return _unitOfWork.RefAmbito.Where(x => (x.ambitoDesc.Contains(pName.Trim()) || string.IsNullOrEmpty(pName)) && (x.estaActivo == pActivo || pActivo == null)).ToList();
        //}

        //public RefAmbito SearchbyIdAmbito(int pId)
        //{
        //    return db.RefAmbito.FirstOrDefault(x => x.idAmbito == pId);
        //}
        //public bool InsertOrUpdate(RefAmbito pORefAmbito)
        //{
        //    try
        //    {
        //        ObjectParameter errorRetornado = new ObjectParameter("error", typeof(String));

        //        if (pORefAmbito.idAmbito == 0)
        //            msp.spRefAmbitoINS(pORefAmbito.ambitoDesc, errorRetornado);
        //        else
        //            msp.spRefAmbitoUPD(pORefAmbito.idAmbito, pORefAmbito.ambitoDesc, errorRetornado);

        //        this.error = errorRetornado.Value.ToString();
        //        return (error != string.Empty) ? false : true;
        //    }
        //    catch (Exception ex)
        //    {
        //        this.error = "Error al Registrar! " + ex.Message;
        //        return false;
        //    }
        //}
        //public bool DeletedLogical(int pId)
        //{
        //    try
        //    {
        //        ObjectParameter errorRetornado = new ObjectParameter("error", typeof(String));
        //        msp.spRefAmbitoDEL(pId, errorRetornado);
        //        this.error = errorRetornado.Value.ToString();
        //        return (error != string.Empty) ? false : true;
        //    }
        //    catch (Exception ex)
        //    {
        //        this.error = "Error al eliminar! " + ex.Message;
        //        return false;
        //    }
        //}
        //public bool IntegrityCheck(RefAmbito pObject)
        //{
        //    try
        //    {
        //        ObjectParameter errorRetornado = new ObjectParameter("error", typeof(String));
        //        msp.spCheckDELETE("RefAmbito", pObject.idAmbito, errorRetornado);
        //        this.error = errorRetornado.Value.ToString();
        //        return (error == "True") ? false : true;
        //    }
        //    catch (Exception ex)
        //    {
        //        this.error = "Error" + ex.Message;
        //        return false;
        //    }
        //}
        //public bool RepeatedObjectCheck(RefAmbito pObject)
        //{
        //    var item = 0;
        //    if (pObject.idAmbito == 0)
        //        item = db.RefAmbito.Count(t => t.ambitoDesc == pObject.ambitoDesc && t.estaActivo == true);
        //    else
        //        item = db.RefAmbito.Count(t => t.ambitoDesc == pObject.ambitoDesc && t.idAmbito != pObject.idAmbito && t.estaActivo == true);
        //    return (item == 0) ? true : false;
        //}
        //public object List()
        //{
        //    return db.RefAmbito.ToList().Where(x => x.estaActivo).OrderBy(x => x.ambitoDesc);
        //}
        //#endregion

    }
}
