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
        public async Task<IActionResult> CreateAccountTypeAsync([FromBody] CreateAccountTypeInput input)
        {
            AppResponse<long> response = await _systemLookupsService.CreateAccountTypeAsync(input);
            return Ok(response);
        }
        [HttpPut]
        [Route("[action]")]
        [ProducesResponseType(typeof(AppResponse<bool>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> EditAccountTypeAsync(long id, [FromBody] EditAccountTypeInput input)
        {
            AppResponse<bool> response = await _systemLookupsService.EditAccountTypeAsync(id, input);
            return Ok(response);
        }
        [HttpGet]
        [Route("[action]")]
        [ProducesResponseType(typeof(AppResponse<long>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetAccountTypeAsync(long id)
        {
            AppResponse<LookupDto> response = await _systemLookupsService.GetAccountTypeAsync(id);
            return Ok(response);
        }
        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType(typeof(AppResponse<long>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetAccountTypesAsync([FromBody]GetLookupsInput input)
        {
            AppResponse<AccountTypesQueryOutput> response = await _systemLookupsService.GetAccountTypesAsync(input);
            return Ok(response);
        }
        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType(typeof(AppResponse<long>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> ChangeAccountTypeStatus(long id, [FromBody]ChangeLookupStatusInput input)
        {
            AppResponse<bool> response = await _systemLookupsService.ChangeAccountTypeStatus(id, input);
            return Ok(response);
        }

    }
}
