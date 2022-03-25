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
    public class RefEscalafonController : ControllerBase
    {
        private readonly RefEscalafonService refEscalafonService;
        private readonly IMapper mapper;

        public RefEscalafonController(RefEscalafonService refEscalafonService, IMapper mapper)
        {
            this.refEscalafonService = refEscalafonService;
            this.mapper = mapper;
        }

        [HttpGet("EscalafonGetAll")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await refEscalafonService.Get());
        }

        [HttpGet("FilterByName")]
        public async Task<IActionResult> GetFilterByName(string name)
        {
            return Ok(await refEscalafonService.GetByEscalafonDesc(name));
        }

        [HttpGet("{id:int}", Name = "GetByIdEscalafon")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await refEscalafonService.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> CreateRefEscalafon(RefEscalafonCreateDTO refEscalafonCreacionDTO)
        {
            if (ModelState.IsValid)
            {
                RefEscalafonDTO refEscalafonDTO = mapper.Map<RefEscalafonDTO>(refEscalafonCreacionDTO);

                return Ok(await refEscalafonService.Create(refEscalafonDTO));
            }

            return BadRequest();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateRefEscalafon(RefEscalafonUpdateDTO refEscalafonUpdateDTO)
        {
            if (ModelState.IsValid)
            {
                RefEscalafonDTO refEscalafonDTO = mapper.Map<RefEscalafonDTO>(refEscalafonUpdateDTO);

                return Ok(await refEscalafonService.Update(refEscalafonDTO));
            }

            return BadRequest();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteRefEscalafon(RefEscalafonUpdateDTO refEscalafonUpdateDTO)
        {
            if (ModelState.IsValid)
            {
                RefEscalafonDTO refEscalafonDTO = mapper.Map<RefEscalafonDTO>(refEscalafonUpdateDTO);

                return Ok(await refEscalafonService.Delete(refEscalafonDTO));
            }
            return BadRequest();
        }

    }
}