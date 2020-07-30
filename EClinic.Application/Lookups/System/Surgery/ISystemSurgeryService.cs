using Abp.Application.Services;
using EClinic.AppDomain.Lookups;
using EClinic.AppDomain.Lookups.Models;
using EClinic.AppDomain.Lookups.Models.Bank.Dto;
using EClinic.AppDomain.Lookups.Models.Surgery;
using EClinic.Core.Lookups;
using EClinic.Framework.HttpModels;
using System.Threading.Tasks;

namespace EClinic.AppServices.Lookups
{
    public partial interface ISystemLookupsService : IApplicationService
    {
        Task<AppResponse<long>> CreateSurgeryAsync(CreateSurgeryInput input);
        Task<AppResponse<bool>> EditSurgeryAsync(long id, EditSurgeryInput input);
        Task<AppResponse<bool>> ChangeSurgeryStatus(long id, ChangeLookupStatusInput input);
        Task<AppResponse<SurgeriesQueryOutput>> GetSurgeriesAsync(GetLookupsInput input);
        Task<AppResponse<SurgeryDto>> GetSurgeryAsync(long id);


    }
}