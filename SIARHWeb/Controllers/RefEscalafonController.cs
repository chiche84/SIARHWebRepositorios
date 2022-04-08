using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;

using SIARH.Aplication.DTOs;
using SIARH.Aplication.DTOs.RefEscalafon;
using SIARH.Aplication.Models;
using SIARH.Aplication.Services;
using SIARH.Persistence.Filters;
using SIARH.Persistence.Models;
using System.Text.Json;

namespace SIARHWeb.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RefEscalafonController : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly IMediator mediator;


        public RefEscalafonController(IMapper mapper, IMediator mediator)
        {
            this.mapper = mapper;
            this.mediator = mediator;   
        }

        [HttpGet("EscalafonGetAll")]
        public async Task<IActionResult> GetAll()
        {
            var response = await mediator.Send(new RefEscalafonGet());
            var lista = mapper.Map<Result<RefEscalafonGetDTO>>(response);
            return Ok(lista);
        }

        [HttpGet("FilterByName")]
        public async Task<IActionResult> GetFilterByName(string escalafondesc )
        {
            var response = await mediator.Send(new RefEscalafonGetByEscalafonDesc(){ EscalafonDesc = escalafondesc });
            var lista = mapper.Map<Result<RefEscalafonGetDTO>>(response);
            return Ok(lista);
        }

        [HttpGet("{id:int}", Name = "GetByIdEscalafon")]
        public async Task<IActionResult> GetById(int id)
        {
            var response = await mediator.Send(new RefEscalafonGetById() { IdEscalafon = id });
            var lista = mapper.Map<Result<RefEscalafonGetDTO>>(response);
            return Ok(lista);
        }

        [HttpPost]
        public async Task<IActionResult> CreateRefEscalafon(RefEscalafonCreateCommand refEscalafonCreateCommand)
        {
            var response = await mediator.Send(refEscalafonCreateCommand);

            if (response.Succeeded)
            {
                return Ok(response);
            }
            return BadRequest(response);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateRefEscalafon(RefEscalafonUpdateCommand refEscalafonUpdateCommand)
        {
            var response = await mediator.Send(refEscalafonUpdateCommand);

            if (response.Succeeded)
            {
                return Ok(response);
            }
            return BadRequest(response);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteRefEscalafon(RefEscalafonDeleteCommand refEscalafonDeleteCommand)
        {
            var response = await mediator.Send(refEscalafonDeleteCommand);

            if (response.Succeeded)
            {
                return Ok(response);
            }
            return BadRequest(response);
        }

    }
}