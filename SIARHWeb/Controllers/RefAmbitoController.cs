using AutoMapper;

using MediatR;

using Microsoft.AspNetCore.Mvc;

using SIARH.Aplication.DTOs;
using SIARH.Aplication.DTOs.RefAmbito;
using SIARH.Aplication.Models;
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
        private readonly IMapper mapper;
        private readonly IMediator mediator;

        public RefAmbitoController(RefAmbitoService refAmbitoService, IMapper mapper, IMediator mediator)
        {
            this.refAmbitoService = refAmbitoService;
            this.mapper = mapper;
            this.mediator = mediator;
        }

        [HttpGet("ambitoGetAll")]
        public async Task<IActionResult> GetAll()
        {
            var response = await refAmbitoService.Get();

            var lista = mapper.Map<Result<RefAmbitoGetDTO>>(response);

            //var lista = mapper.Map<List<RefAmbitoViewDTO>>(response.Entities);

            return Ok(lista);
        }

        [HttpGet("FilterByName")]
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
            if (ModelState.IsValid)
            {
                //var response = await refAmbitoService.Create(refAmbitoCreacionDTO);

                return Ok(await refAmbitoService.Create(refAmbitoCreacionDTO));
            }
            return BadRequest();
        }

        [HttpGet("getmediator")]
        public async Task<IActionResult> GetAmbitosMediator()
        {
            var response = await mediator.Send(new RefAmbitoRequestModel());
            var lista = mapper.Map<Result<RefAmbitoGetDTO>>(response);
            return Ok(lista);
        }

        [HttpPost("mediator")]
        public async Task<IActionResult> CreateRefAmbitoMediator(RefAmbitoCreateCommand refAmbitoCreateCommand)
        {        
            var response = await mediator.Send(refAmbitoCreateCommand);
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateRefAmbito(RefAmbitoUpdateDTO refAmbitoUpdateDTO)
        {
            if (ModelState.IsValid)
            {
                //RefAmbitoDTO refAmbitoDTO = mapper.Map<RefAmbitoDTO>(refAmbitoUpdateDTO);
                
                return Ok(await refAmbitoService.Update(refAmbitoUpdateDTO));
            }
            return BadRequest();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteRefAmbito(RefAmbitoUpdateDTO refAmbitoUpdateDTO)
        {
            if (ModelState.IsValid)
            {
                //RefAmbitoDTO refAmbitoDTO = mapper.Map<RefAmbitoDTO>(refAmbitoUpdateDTO);

                return Ok(await refAmbitoService.Delete(refAmbitoUpdateDTO));
            }

            return BadRequest();
        }

    }
}