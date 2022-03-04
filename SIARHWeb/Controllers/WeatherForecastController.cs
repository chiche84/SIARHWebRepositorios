
using Microsoft.AspNetCore.Mvc;

using SIARH.Aplication;
using SIARH.Persistence;
using SIARH.Persistence.Models;

namespace SIARHWeb.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IRefAmbitoRepository refAmbitoRepository;
        
        //private readonly IGenericRepository<RefAmbito> genericRepository;

        //public WeatherForecastController(IGenericRepository<RefAmbito> genericRepository, ILogger<WeatherForecastController> logger)
        //{
        //    this.genericRepository = genericRepository;
        //    _logger = logger;
        //}

        public WeatherForecastController(IRefAmbitoRepository refAmbitoRepository)
        {           
            this.refAmbitoRepository = refAmbitoRepository;
            
        }

        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

              
        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet("ambitoGetAll")]
        public async Task<IActionResult> Geti()
        {
            return Ok(await refAmbitoRepository.All());
        }

        [HttpGet("ambitoFilter")]
        public async Task<IActionResult> FilterBy(string valor)
        {
            return Ok(await refAmbitoRepository.All());
        }
    }
}