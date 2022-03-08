
using AutoMapper;

using Microsoft.AspNetCore.Mvc;

using SIARH.Aplication;
using SIARH.Aplication.DTOs;
using SIARH.Aplication.Services;
using SIARH.Persistence;
using SIARH.Persistence.Models;
using SIARH.Persistence.UnitOfWork;

namespace SIARHWeb.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RefAmbitoController : ControllerBase
    {
                
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public RefAmbitoController(IUnitOfWork unitOfWork, IMapper mapper)
        {           
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
                    
        [HttpGet("ambitoGetAll")]
        public async Task<IActionResult> GetAll()
        {
            BllRefAmbito bllRefAmbito = new BllRefAmbito(unitOfWork); 
            return Ok(await bllRefAmbito.Filter(new SIARH.Persistence.Filters.RefAmbitoFilter() { EstaActivo = true }));
        }

        [HttpGet("{name}", Name = "FilterByName")]
        public async Task<IActionResult> GetFilterByName(string name)
        {
            BllRefAmbito bllRefAmbito = new BllRefAmbito(unitOfWork);
            return Ok(await bllRefAmbito.Filter(new SIARH.Persistence.Filters.RefAmbitoFilter() { AmbitoDesc=name, EstaActivo = true }));
        }

        [HttpGet("{id:int}", Name = "GetAmbito")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await unitOfWork.RefAmbito.GetById(id));
        }
        [HttpPost]
        public async Task<IActionResult> CreateRefAmbitoRefEscalafon(totalDTO totalDTO)
        {
            if (ModelState.IsValid)
            {
                RefAmbito refAmbito = mapper.Map<RefAmbito>(totalDTO);
                RefEscalafon refEscalafon = mapper.Map<RefEscalafon>(totalDTO);
                await unitOfWork.RefAmbito.Add(refAmbito);
                await unitOfWork.RefEscalafon.Add(refEscalafon);
                await unitOfWork.CompleteAsync();

                return CreatedAtRoute("GetAmbito", new { id = refAmbito.IdAmbito }, refAmbito);                
            }

            return new JsonResult("No se pudo completar la transaccion") { StatusCode = 500 };
        }

    }
}