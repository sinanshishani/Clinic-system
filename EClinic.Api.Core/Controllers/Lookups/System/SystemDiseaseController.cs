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
        public async Task<IActionResult> CreateDiseaseAsync([FromBody] CreateDiseaseInput input)
        {
            AppResponse<long> response = await _systemLookupsService.CreateDiseaseAsync(input);
            return Ok(response);
        }
        [HttpPut]
        [Route("[action]")]
        [ProducesResponseType(typeof(AppResponse<bool>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> EditDiseaseAsync(long id, [FromBody] EditDiseaseInput input)
        {
            AppResponse<bool> response = await _systemLookupsService.EditDiseaseAsync(id, input);
            return Ok(response);
        }
        [HttpGet]
        [Route("[action]")]
        [ProducesResponseType(typeof(AppResponse<long>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetDiseaseAsync(long id)
        {
            AppResponse<LookupDto> response = await _systemLookupsService.GetDiseaseAsync(id);
            return Ok(response);
        }
        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType(typeof(AppResponse<long>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetDiseasesAsync([FromBody] GetLookupsInput input)
        {
            AppResponse<DiseasesQueryOutput> response = await _systemLookupsService.GetDiseasesAsync(input);
            return Ok(response);
        }
        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType(typeof(AppResponse<long>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> ChangeDiseaseStatus(long id, [FromBody] ChangeLookupStatusInput input)
        {
            AppResponse<bool> response = await _systemLookupsService.ChangeDiseaseStatus(id, input);
            return Ok(response);
        }

    }
}
