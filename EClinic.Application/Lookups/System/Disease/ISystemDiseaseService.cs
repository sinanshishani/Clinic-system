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
        Task<AppResponse<long>> CreateDiseaseAsync(CreateDiseaseInput input);
        Task<AppResponse<bool>> EditDiseaseAsync(long id, EditDiseaseInput input);
        Task<AppResponse<LookupDto>> GetDiseaseAsync(long id);
        Task<AppResponse<bool>> ChangeDiseaseStatus(long id, ChangeLookupStatusInput input);
        Task<AppResponse<DiseasesQueryOutput>> GetDiseasesAsync(GetLookupsInput input);

    }
}