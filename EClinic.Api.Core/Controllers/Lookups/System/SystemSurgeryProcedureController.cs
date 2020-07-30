using EClinic.AppDomain.Lookups;
using EClinic.AppDomain.Lookups.Models;
using EClinic.Core.Lookups;
using EClinic.Framework.HttpModels;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Threading.Tasks;

namespace EClinic.Controllers
{
    public partial class SystemLookupsController : ControllerBase
    {
        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType(typeof(AppResponse<long>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> CreateSurgeryProcedureAsync([FromBody] CreateSurgeryProcedureInput input)
        {
            AppResponse<long> response = await _systemLookupsService.CreateSurgeryProcedureAsync(input);
            return Ok(response);
        }
        [HttpPut]
        [Route("[action]")]
        [ProducesResponseType(typeof(AppResponse<bool>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> EditSurgeryProcedureAsync(long id, [FromBody] EditSurgeryProcedureInput input)
        {
            AppResponse<bool> response = await _systemLookupsService.EditSurgeryProcedureAsync(id, input);
            return Ok(response);
        }
        [HttpGet]
        [Route("[action]")]
        [ProducesResponseType(typeof(AppResponse<long>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetSurgeryProceduresAsync([FromBody]GetLookupsInput input)
        {
            AppResponse<SurgeryProceduresQueryOutput> response = await _systemLookupsService.GetSurgeryProceduresAsync(input);
            return Ok(response);
        }
        [HttpPut]
        [Route("[action]")]
        [ProducesResponseType(typeof(AppResponse<long>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> ChangeSurgeryProcedureStatus(long id, [FromBody]ChangeLookupStatusInput input)
        {
            AppResponse<bool> response = await _systemLookupsService.ChangeSurgeryProcedureStatus(id, input);
            return Ok(response);
        }

    }
}
