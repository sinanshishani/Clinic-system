using EClinic.Application.Patients;
using EClinic.Framework.HttpModels;
using EClinic.Core.Patients;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Threading.Tasks;

namespace EClinic.Api.Core.Controllers
{
    [Route("api/v1/patients")]
    public class PatientsController : ControllerBase
    {
        private readonly IPatientService _patientService;

        public PatientsController(IPatientService patientService)
        {
            _patientService = patientService;
        }


        // POST: api/v1/patients
        [HttpPost]
        [Route("")]
        [ProducesResponseType(typeof(AppResponse), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> CreateAsync([FromBody]CreatePatientInput input)
        {
            AppResponse response = await _patientService.CreatePatientAsync(input);
            return Ok(response);
        }


        // GET: api/v1/patients
        [HttpGet]
        [Route("")]
        [ProducesResponseType(typeof(AppResponse<PatientsQueryOutput>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> PatientsQueryAsync(/*[FromQuery] PatientsQueryInput input*/)
        {
            AppResponse<PatientsQueryOutput> response = null; //= await _patientService.PatientsQueryAsync(input);
            return Ok(response);
        }
    }
}
