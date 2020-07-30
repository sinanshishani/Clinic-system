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
        Task<AppResponse<long>> CreateAllergicAsync(CreateAllergicInput input);
        Task<AppResponse<bool>> EditAllergicAsync(long id, EditAllergicInput input);
        Task<AppResponse<LookupDto>> GetAllergicAsync(long id);
        Task<AppResponse<bool>> ChangeAllergicStatus (long id, ChangeLookupStatusInput input);
        Task<AppResponse<AllergiesQueryOutput>> GetAllergiesAsync(GetLookupsInput input);

    }
}