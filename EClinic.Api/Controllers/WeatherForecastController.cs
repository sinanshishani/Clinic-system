using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EClinic.Application.Patients;
using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace EClinic.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger _logger;

        private readonly IPatientService _patientService;

        public WeatherForecastController(IPatientService patientService)
        {
            _patientService = patientService;
        }

        //public WeatherForecastController(ILogger logger)
        //{
        //    _logger = logger;
        //}

        [HttpGet]
        public IEnumerable<string> Get()
        {
            //_logger.Error("sdfshsdfgh dfg dfsdfg dfg dfg");
            return Summaries;
        }
    }
}
