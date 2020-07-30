using EClinic.AppDomain.Lookups;
using EClinic.AppDomain.Lookups.Models;
using EClinic.AppDomain.Lookups.Models.Bank.Dto;
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
        public async Task<IActionResult> CreateMedicalVisitProcedureAsync([FromBody] CreateMedicalVisitProcedureInput input)
        {
            AppResponse<long> response = await _systemLookupsService.CreateMedicalVisitProcedureAsync(input);
            return Ok(response);
        }
        [HttpPut]
        [Route("[action]")]
        [ProducesResponseType(typeof(AppResponse<bool>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> EditMedicalVisitProcedureAsync(long id, [FromBody] EditMedicalVisitProcedureInput input)
        {
            AppResponse<bool> response = await _systemLookupsService.EditMedicalVisitProcedureAsync(id, input);
            return Ok(response);
        }
        [HttpGet]
        [Route("[action]")]
        [ProducesResponseType(typeof(AppResponse<long>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetMedicalVisitProcedureAsync(long id)
        {
            AppResponse<LookupDto> response = await _systemLookupsService.GetMedicalVisitProcedureAsync(id);
            return Ok(response);
        }
        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType(typeof(AppResponse<long>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetMedicalVisitProceduresAsync([FromBody]GetLookupsInput input)
        {
            AppResponse<MedicalVisitProceduresQueryOutput> response = await _systemLookupsService.GetMedicalVisitProceduresAsync(input);
            return Ok(response);
        }
        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType(typeof(AppResponse<long>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> ChangeMedicalVisitProcedureStatus(long id, [FromBody]ChangeLookupStatusInput input)
        {
            AppResponse<bool> response = await _systemLookupsService.ChangeMedicalVisitProcedureStatus(id, input);
            return Ok(response);
        }

    }
}
