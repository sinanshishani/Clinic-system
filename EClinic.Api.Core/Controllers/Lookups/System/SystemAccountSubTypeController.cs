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
        public async Task<IActionResult> CreateAccountSubTypeAsync([FromBody] CreateAccountSubTypeInput input)
        {
            AppResponse<long> response = await _systemLookupsService.CreateAccountSubTypeAsync(input);
            return Ok(response);
        }
        [HttpPut]
        [Route("[action]")]
        [ProducesResponseType(typeof(AppResponse<bool>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> EditAccountSubTypeAsync(long id, [FromBody] EditAccountSubTypeInput input)
        {
            AppResponse<bool> response = await _systemLookupsService.EditAccountSubTypeAsync(id, input);
            return Ok(response);
        }
        [HttpGet]
        [Route("[action]")]
        [ProducesResponseType(typeof(AppResponse<AccountSubTypeDto>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetAccountSubTypeAsync(long id)
        {
            AppResponse<AccountSubTypeDto> response = await _systemLookupsService.GetAccountSubTypeAsync(id);
            return Ok(response);
        }
        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType(typeof(AppResponse<AccountSubTypesQueryOutput>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetAccountSubTypesAsync([FromBody]GetLookupsInput input)
        {
            AppResponse<AccountSubTypesQueryOutput> response = await _systemLookupsService.GetAccountSubTypesAsync(input);
            return Ok(response);
        }
        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType(typeof(AppResponse<bool>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> ChangeAccountSubTypeStatus(long id, [FromBody]ChangeLookupStatusInput input)
        {
            AppResponse<bool> response = await _systemLookupsService.ChangeAccountSubTypeStatus(id, input);
            return Ok(response);
        }

    }
}
