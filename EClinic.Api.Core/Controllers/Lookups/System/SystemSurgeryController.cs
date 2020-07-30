using EClinic.AppDomain.Lookups;
using EClinic.AppDomain.Lookups.Models;
using EClinic.AppDomain.Lookups.Models.Surgery;
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
        public async Task<IActionResult> CreateSurgeryAsync([FromBody] CreateSurgeryInput input)
        {
            AppResponse<long> response = await _systemLookupsService.CreateSurgeryAsync(input);
            return Ok(response);
        }
        [HttpPut]
        [Route("[action]")]
        [ProducesResponseType(typeof(AppResponse<bool>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> EditSurgeryAsync(long id, [FromBody] EditSurgeryInput input)
        {
            AppResponse<bool> response = await _systemLookupsService.EditSurgeryAsync(id, input);
            return Ok(response);
        }
        [HttpGet]
        [Route("[action]")]
        [ProducesResponseType(typeof(AppResponse<SurgeriesQueryOutput>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetSurgeriesAsync([FromBody]GetLookupsInput input)
        {
            AppResponse<SurgeriesQueryOutput> response = await _systemLookupsService.GetSurgeriesAsync(input);
            return Ok(response);
        }
        [HttpPut]
        [Route("[action]")]
        [ProducesResponseType(typeof(AppResponse<bool>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> ChangeSurgerStatus(long id, [FromBody]ChangeLookupStatusInput input)
        {
            AppResponse<bool> response = await _systemLookupsService.ChangeSurgeryStatus(id, input);
            return Ok(response);
        }
        [HttpGet]
        [Route("[action]")]
        [ProducesResponseType(typeof(AppResponse<SurgeryDto>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetSurger(long id)
        {
            AppResponse<SurgeryDto> response = await _systemLookupsService.GetSurgeryAsync(id);
            return Ok(response);
        }

    }
}
