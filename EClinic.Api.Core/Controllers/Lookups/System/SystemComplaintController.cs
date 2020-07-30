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
        public async Task<IActionResult> CreateComplaintAsync([FromBody] CreateComplaintInput input)
        {
            AppResponse<long> response = await _systemLookupsService.CreateComplaintAsync(input);
            return Ok(response);
        }
        [HttpPut]
        [Route("[action]")]
        [ProducesResponseType(typeof(AppResponse<bool>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> EditComplaintAsync(long id, [FromBody] EditComplaintInput input)
        {
            AppResponse<bool> response = await _systemLookupsService.EditComplaintAsync(id, input);
            return Ok(response);
        }
        [HttpGet]
        [Route("[action]")]
        [ProducesResponseType(typeof(AppResponse<long>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetComplaintAsync(long id)
        {
            AppResponse<LookupDto> response = await _systemLookupsService.GetComplaintAsync(id);
            return Ok(response);
        }
        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType(typeof(AppResponse<long>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetComplaintsAsync([FromBody]GetLookupsInput input)
        {
            AppResponse<ComplaintsQueryOutput> response = await _systemLookupsService.GetComplaintsAsync(input);
            return Ok(response);
        }
        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType(typeof(AppResponse<long>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> ChangeComplaintStatus(long id, [FromBody]ChangeLookupStatusInput input)
        {
            AppResponse<bool> response = await _systemLookupsService.ChangeComplaintStatus(id, input);
            return Ok(response);
        }

    }
}
