using Microsoft.AspNetCore.Mvc;

using SIARH.Aplication.DTOs;
using SIARH.Aplication.Services;
using SIARH.Persistence.Filters;
using SIARH.Persistence.Models;

namespace SIARHWeb.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RefAmbitoController : ControllerBase
    {           
        private readonly RefAmbitoService refAmbitoService;

        public RefAmbitoController(RefAmbitoService refAmbitoService)
        {  
            this.refAmbitoService = refAmbitoService;
        }
                    
        [HttpGet("ambitoGetAll")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await refAmbitoService.Filter(new RefAmbitoFilter() { EstaActivo = true }));
        }

        [HttpGet("{name}", Name = "FilterByName")]
        public async Task<IActionResult> GetFilterByName(string name)
        {
            return Ok(await refAmbitoService.Filter(new RefAmbitoFilter() { AmbitoDesc = name, EstaActivo = true }));
        }

        [HttpGet("{id:int}", Name = "GetByIdAmbito")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await refAmbitoService.Filter(new RefAmbitoFilter() { IdAmbito = id, EstaActivo = true }));
        }

        [HttpPost]
        public async Task<IActionResult> CreateRefAmbitoRefEscalafon(RefAmbitoCreacionDTO refAmbitoCreacionDTO)
        {
            if (ModelState.IsValid)
            {
                RefAmbito refAmbito = await refAmbitoService.Add(refAmbitoCreacionDTO);
                return CreatedAtRoute("GetByIdAmbito", new { id = refAmbito.IdAmbito }, refAmbito);                
            }

            return new JsonResult("No se pudo completar la transaccion") { StatusCode = 500 };
        }

    }
}