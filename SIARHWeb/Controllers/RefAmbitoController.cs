using Microsoft.AspNetCore.Mvc;

using SIARH.Aplication.DTOs;
using SIARH.Aplication.Models;
using SIARH.Aplication.Services;
using SIARH.Persistence.Filters;
using SIARH.Persistence.Models;
using System.Text.Json;

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
            var x = await refAmbitoService.Filter(new RefAmbitoFilter() { EstaActivo = true });

            //var options = new JsonSerializerOptions { WriteIndented = true };
            //string jsonString = JsonSerializer.Serialize(weatherForecast, options);

            //string jsonString = JsonSerializer.Serialize(x => x.En);

            //Console.WriteLine(jsonString);

            //return Ok(jsonString);

            //return Ok(x.Entities[0]);
            return Ok(x);
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
            //Result<IRefAmbitoDTO> x;

            //if (ModelState.IsValid)
            //{

            var x = await refAmbitoService.Add(refAmbitoCreacionDTO);
               return  Ok(x);

                
            //}
            //return x;
            //return new Result<IRefAmbitoDTO>() { };  //new JsonResult("No se pudo completar la transaccion") { StatusCode = 500 };
        }

    }
}