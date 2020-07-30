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
        Task<AppResponse<long>> CreateSurgeryProcedureAsync(CreateSurgeryProcedureInput input);
        Task<AppResponse<bool>> EditSurgeryProcedureAsync(long id, EditSurgeryProcedureInput input);
        Task<AppResponse<bool>> ChangeSurgeryProcedureStatus(long id, ChangeLookupStatusInput input);
        Task<AppResponse<SurgeryProceduresQueryOutput>> GetSurgeryProceduresAsync(GetLookupsInput input);
    }
}