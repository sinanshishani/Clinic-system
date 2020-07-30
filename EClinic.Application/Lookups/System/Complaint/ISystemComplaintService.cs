using Abp.Application.Services;
using EClinic.AppDomain.Lookups;
using EClinic.AppDomain.Lookups.Models;
using EClinic.AppDomain.Lookups.Models.Bank.Dto;
using EClinic.Core.Lookups;
using EClinic.Framework.HttpModels;
using System.Threading.Tasks;

namespace EClinic.AppServices.Lookups
{
    public partial interface ISystemLookupsService : IApplicationService
    {
        Task<AppResponse<long>> CreateComplaintAsync(CreateComplaintInput input);
        Task<AppResponse<bool>>EditComplaintAsync(long id, EditComplaintInput input);
        Task<AppResponse<LookupDto>> GetComplaintAsync(long id);
        Task<AppResponse<bool>> ChangeComplaintStatus(long id, ChangeLookupStatusInput input);
        Task<AppResponse<ComplaintsQueryOutput>> GetComplaintsAsync(GetLookupsInput input);

    }
}