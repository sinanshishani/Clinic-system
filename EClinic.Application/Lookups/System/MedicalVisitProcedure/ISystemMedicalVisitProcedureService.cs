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
        Task<AppResponse<long>> CreateMedicalVisitProcedureAsync(CreateMedicalVisitProcedureInput input);
        Task<AppResponse<bool>> EditMedicalVisitProcedureAsync(long id, EditMedicalVisitProcedureInput input);
        Task<AppResponse<LookupDto>> GetMedicalVisitProcedureAsync(long id);
        Task<AppResponse<bool>> ChangeMedicalVisitProcedureStatus (long id, ChangeLookupStatusInput input);
        Task<AppResponse<MedicalVisitProceduresQueryOutput>> GetMedicalVisitProceduresAsync(GetLookupsInput input);

    }
}