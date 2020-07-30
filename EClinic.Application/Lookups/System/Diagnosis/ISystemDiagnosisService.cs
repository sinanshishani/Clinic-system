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
        Task<AppResponse<long>> CreateDiagnosisAsync(CreateDiagnosisInput input);
        Task<AppResponse<bool>> EditDiagnosisAsync(long id, EditDiagnosisInput input);
        Task<AppResponse<LookupDto>> GetDiagnosisAsync(long id);
        Task<AppResponse<bool>> ChangeDiagnosisStatus(long id, ChangeLookupStatusInput input);
        Task<AppResponse<DiagnosisQueryOutput>> GetDiagnosesAsync(GetLookupsInput input);

    }
}