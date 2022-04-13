using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;

using SIARH.Aplication.DTOs;
using SIARH.Aplication.Services.RefGrupoNivels.Dtos;
using SIARH.Aplication.Models;
using SIARH.Aplication.Services;
using SIARH.Persistence.Filters;
using SIARH.Persistence.Models;
using System.Text.Json;

namespace SIARHWeb.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RefGrupoNivelController : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly IMediator mediator;


        public RefGrupoNivelController(IMapper mapper, IMediator mediator)
        {
            this.mapper = mapper;
            this.mediator = mediator;
        }

        [HttpGet("GrupoNivelGetAll")]
        public async Task<IActionResult> GetAll()
        {
            var response = await mediator.Send(new RefGrupoNivelGetQuery());
            var lista = mapper.Map<Result<RefGrupoNivelGetDTO>>(response);
            return Ok(lista);
        }

        [HttpGet("FilterByName")]
        public async Task<IActionResult> GetFilterByName(string grupoDesc)
        {
            var response = await mediator.Send(new RefGrupoNivelGetByEscalafonDescQuery() { GrupoDesc = grupoDesc });
            var lista = mapper.Map<Result<RefGrupoNivelGetDTO>>(response);
            return Ok(lista);
        }

        [HttpGet("{id:int}", Name = "GetByIdGrupoNivel")]
        public async Task<IActionResult> GetById(int id)
        {
            var response = await mediator.Send(new RefGrupoNivelGetByIdQuery() { IdGrupoNivel = id });
            var lista = mapper.Map<Result<RefGrupoNivelGetDTO>>(response);
            return Ok(lista);
        }

        [HttpPost]
        public async Task<IActionResult> CreateRefGrupoNivel(RefGrupoNivelCreateCommand RefGrupoNivelCreateCommand)
        {
            var response = await mediator.Send(RefGrupoNivelCreateCommand);

            if (response.Succeeded)
            {
                return Ok(response);
            }
            return BadRequest(response);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateRefGrupoNivel(RefGrupoNivelUpdateCommand RefGrupoNivelUpdateCommand)
        {
            var response = await mediator.Send(RefGrupoNivelUpdateCommand);

            if (response.Succeeded)
            {
                return Ok(response);
            }
            return BadRequest(response);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteRefGrupoNivel(RefGrupoNivelDeleteCommand RefGrupoNivelDeleteCommand)
        {
            var response = await mediator.Send(RefGrupoNivelDeleteCommand);

            if (response.Succeeded)
            {
                return Ok(response);
            }
            return BadRequest(response);
        }

    }
}