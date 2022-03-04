
using AutoMapper;

using Microsoft.AspNetCore.Mvc;

using SIARH.Aplication;
using SIARH.Aplication.DTOs;
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
            return Ok(await unitOfWork.RefAmbito.All());
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