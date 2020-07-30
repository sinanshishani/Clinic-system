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
        public async Task<IActionResult> CreateAllergicAsync([FromBody] CreateAllergicInput input)
        {
            AppResponse<long> response = await _systemLookupsService.CreateAllergicAsync(input);
            return Ok(response);
        }
        [HttpPut]
        [Route("[action]")]
        [ProducesResponseType(typeof(AppResponse<bool>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> EditAllergicAsync(long id, [FromBody] EditAllergicInput input)
        {
            AppResponse<bool> response = await _systemLookupsService.EditAllergicAsync(id, input);
            return Ok(response);
        }
        [HttpGet]
        [Route("[action]")]
        [ProducesResponseType(typeof(AppResponse<long>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetAllergicAsync(long id)
        {
            AppResponse<LookupDto> response = await _systemLookupsService.GetAllergicAsync(id);
            return Ok(response);
        }
        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType(typeof(AppResponse<long>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetAllergiesAsync([FromBody]GetLookupsInput input)
        {
            AppResponse<AllergiesQueryOutput> response = await _systemLookupsService.GetAllergiesAsync(input);
            return Ok(response);
        }
        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType(typeof(AppResponse<long>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> ChangeAllergicStatus(long id, [FromBody]ChangeLookupStatusInput input)
        {
            AppResponse<bool> response = await _systemLookupsService.ChangeAllergicStatus(id, input);
            return Ok(response);
        }

    }
}
