using AutoMapper;
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
        private readonly IMapper mapper;

        public RefAmbitoController(RefAmbitoService refAmbitoService, IMapper mapper)
        {
            this.refAmbitoService = refAmbitoService;
            this.mapper = mapper;
        }

        [HttpGet("ambitoGetAll")]
        public async Task<IActionResult> GetAll()
        {
            var x = await refAmbitoService.Get();

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
            return Ok(await refAmbitoService.GetByAmbitoDesc(name));
        }

        [HttpGet("{id:int}", Name = "GetByIdAmbito")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await refAmbitoService.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> CreateRefAmbito(RefAmbitoCreateDTO refAmbitoCreacionDTO)
        {
            //Result<IRefAmbitoDTO> x;

            //if (ModelState.IsValid)
            //{
            RefAmbitoDTO refAmbitoDTO = new RefAmbitoDTO() {AmbitoDesc = refAmbitoCreacionDTO.AmbitoDesc };

            var x = await refAmbitoService.Create(refAmbitoDTO);
            return Ok(x);


            //}
            //return x;
            //return new Result<IRefAmbitoDTO>() { };  //new JsonResult("No se pudo completar la transaccion") { StatusCode = 500 };
        }

        [HttpPut]
        public async Task<IActionResult> UpdateRefAmbito(RefAmbitoUpdateDTO refAmbitoUpdateDTO)
        {
            //Result<IRefAmbitoDTO> x;

            //if (ModelState.IsValid)
            //{
            //RefAmbitoDTO refAmbitoDTO = (RefAmbitoDTO)refAmbitoUpdateDTO;

            RefAmbitoDTO refAmbitoDTO = mapper.Map<RefAmbitoDTO>(refAmbitoUpdateDTO);

            var x = await refAmbitoService.Update(refAmbitoDTO);
            return Ok(x);


            //}
            //return x;
            //return new Result<IRefAmbitoDTO>() { };  //new JsonResult("No se pudo completar la transaccion") { StatusCode = 500 };
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteRefAmbito(RefAmbitoUpdateDTO refAmbitoUpdateDTO)
        {
            //Result<IRefAmbitoDTO> x;

            //if (ModelState.IsValid)
            //{

            RefAmbitoDTO refAmbitoDTO = mapper.Map<RefAmbitoDTO>(refAmbitoUpdateDTO);


            var x = await refAmbitoService.Delete(refAmbitoDTO);
            return Ok(x);


            //}
            //return x;
            //return new Result<IRefAmbitoDTO>() { };  //new JsonResult("No se pudo completar la transaccion") { StatusCode = 500 };
        }

    }
}