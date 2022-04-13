using AutoMapper;
using Me.Siarh.Common.Application;
using Me.Siarh.Pof.Application.RefFuncionEntity.Dtos;
using Me.Siarh.Pof.Application.RefFuncionEntity.Handlers;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace Me.Siarh.Pof.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RefFuncionController : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly IMediator mediator;


        public RefFuncionController(IMapper mapper, IMediator mediator)
        {
            this.mapper = mapper;
            this.mediator = mediator;   
        }

        [HttpGet("FuncionGetAll")]
        public async Task<IActionResult> GetAll()
        {
            var response = await mediator.Send(new RefFuncionGet());
            var lista = mapper.Map<Result<RefFuncionGetDTO>>(response);
            return Ok(lista);
        }

        [HttpGet("FilterByName")]
        public async Task<IActionResult> GetFilterByName(string funciondesc )
        {
            var response = await mediator.Send(new RefFuncionGetByFuncionDesc(){ FuncionDesc = funciondesc });
            var lista = mapper.Map<Result<RefFuncionGetDTO>>(response);
            return Ok(lista);
        }

        [HttpGet("{id:int}", Name = "GetById")]
        public async Task<IActionResult> GetById(int id)
        {
            var response = await mediator.Send(new RefFuncionGetById() { IdFuncion = id });
            var lista = mapper.Map<Result<RefFuncionGetDTO>>(response);
            return Ok(lista);
        }

        [HttpPost]
        public async Task<IActionResult> CreateRefFuncion(RefFuncionCreateCommand RefFuncionCreateCommand)
        {
            var response = await mediator.Send(RefFuncionCreateCommand);

            if (response.Succeeded)
            {
                return Ok(response);
            }
            return BadRequest(response);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateRefFuncion(RefFuncionUpdateCommand RefFuncionUpdateCommand)
        {
            var response = await mediator.Send(RefFuncionUpdateCommand);

            if (response.Succeeded)
            {
                return Ok(response);
            }
            return BadRequest(response);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteRefFuncion(RefFuncionDeleteCommand RefFuncionDeleteCommand)
        {
            var response = await mediator.Send(RefFuncionDeleteCommand);

            if (response.Succeeded)
            {
                return Ok(response);
            }
            return BadRequest(response);
        }

    }
}