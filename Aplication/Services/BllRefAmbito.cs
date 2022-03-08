using SIARH.Persistence.Filters;
using SIARH.Persistence.Models;
using SIARH.Persistence.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIARH.Aplication.Services
{
    public class BllRefAmbito //: BLLBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public BllRefAmbito(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;   
        }


        public async Task<IEnumerable<RefAmbito>> Filter(RefAmbitoFilter filter)
        {
            return await _unitOfWork.RefAmbito.Filter(filter);
        }

        //#region METODOS
        //public object Search(string pName, bool? pActivo)
        //{
        //    return _unitOfWork.RefAmbito..Where(x => (x.ambitoDesc.Contains(pName.Trim()) || string.IsNullOrEmpty(pName)) && (x.estaActivo == pActivo || pActivo == null)).ToList();
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
