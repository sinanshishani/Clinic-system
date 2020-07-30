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
        Task<AppResponse<long>> CreateAccountTypeAsync(CreateAccountTypeInput input);
        Task<AppResponse<bool>> EditAccountTypeAsync(long id, EditAccountTypeInput input);
        Task<AppResponse<LookupDto>> GetAccountTypeAsync(long id);
        Task<AppResponse<bool>> ChangeAccountTypeStatus (long id, ChangeLookupStatusInput input);
        Task<AppResponse<AccountTypesQueryOutput>> GetAccountTypesAsync(GetLookupsInput input);

    }
}