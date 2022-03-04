
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
        private readonly RefAmbitoRepository refAmbitoRepository;
        private readonly ILogger<WeatherForecastController> _logger;
        //private readonly IGenericRepository<RefAmbito> genericRepository;

        //public WeatherForecastController(IGenericRepository<RefAmbito> genericRepository, ILogger<WeatherForecastController> logger)
        //{
        //    this.genericRepository = genericRepository;
        //    _logger = logger;
        //}

        public WeatherForecastController(RefAmbitoRepository refAmbitoRepository, ILogger<WeatherForecastController> logger)
        {           
            this.refAmbitoRepository = refAmbitoRepository;
            _logger = logger;
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
            return Ok(await refAmbitoRepository.GetAll());
        }

        [HttpGet("ambitoFilter")]
        public async Task<IActionResult> FilterBy(string valor)
        {
            return Ok(await refAmbitoRepository.FilterBy(valor));
        }
    }
}