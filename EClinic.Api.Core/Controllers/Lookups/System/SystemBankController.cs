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
    [Route("api/v1/systemLookups")]
    public partial class SystemLookupsController : ControllerBase
    {
        [HttpPost]
        [Route("banks")]
        [ProducesResponseType(typeof(AppResponse<long>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> CreateBankAsync([FromBody] CreateBankInput input)
        {
            AppResponse<long> response = await _systemLookupsService.CreateBankAsync(input);
            return Ok(response);
        }
        [HttpPut]
        [Route("banks/{id?}")]
        [ProducesResponseType(typeof(AppResponse<bool>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> EditBankAsync(long id, [FromBody] EditBankInput input)
        {
            AppResponse<bool> response = await _systemLookupsService.EditBankAsync(id, input);
            return Ok(response);
        }
        [HttpGet]
        [Route("banks/{id?}")]
        [ProducesResponseType(typeof(AppResponse<long>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetBankAsync(long id)
        {
            AppResponse<LookupDto> response = await _systemLookupsService.GetBankAsync(id);
            return Ok(response);
        }
        [HttpGet]
        [Route("banks")]
        [ProducesResponseType(typeof(AppResponse<long>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetBanksAsync([FromBody]GetLookupsInput input)
        {
            AppResponse<BanksQueryOutput> response = await _systemLookupsService.GetBanksAsync(input);
            return Ok(response);
        }
        [HttpPut]
        [Route("banks/{id?}/status")]
        [ProducesResponseType(typeof(AppResponse<long>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> ChangeBankStatus(long id ,[FromBody]ChangeLookupStatusInput input)
        {
            AppResponse<bool> response = await _systemLookupsService.ChangeBankStatus(id,input);
            return Ok(response);
        }

    }
}
