using EClinic.AppDomain.Lookups;
using EClinic.AppServices.Lookups;
using EClinic.Framework.HttpModels;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Threading.Tasks;

namespace EClinic.Controllers
{
    [Route("api/v1/systemLookups")]
    public partial class SystemLookupsController : ControllerBase
    {
        private readonly ISystemLookupsService _systemLookupsService;

        public SystemLookupsController(ISystemLookupsService systemLookupsService)
        {
            _systemLookupsService = systemLookupsService;
        }

        // POST: api/v1/systemLookups
        [HttpPost]
        [Route("")]
        [ProducesResponseType(typeof(AppResponse<long>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> CreateAsync([FromBody]CreateSurgeryInput input)
        {
            AppResponse<long> response = await _systemLookupsService.CreateSurgeryAsync(input);
            return Ok(response);
        }


        //// GET: api/v1/systemLookups
        //[HttpGet]
        //[Route("")]
        //[ProducesResponseType(typeof(AppResponse<PatientsQueryOutput>), (int)HttpStatusCode.OK)]
        //public async Task<IActionResult> PatientsQueryAsync([FromQuery] PatientsQueryInput input)
        //{
        //    AppResponse<PatientsQueryOutput> response = await _patientService.PatientsQueryAsync(input);
        //    return Ok(response);
        //}
    }
}
