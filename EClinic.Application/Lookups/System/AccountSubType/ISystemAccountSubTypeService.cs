using Abp.Application.Services;
using EClinic.AppDomain.Lookups;
using EClinic.AppDomain.Lookups.Models;
using EClinic.Core.Lookups;
using EClinic.Framework.HttpModels;
using System.Threading.Tasks;

namespace EClinic.AppServices.Lookups
{
    public partial interface ISystemLookupsService : IApplicationService
    {
        Task<AppResponse<long>> CreateAccountSubTypeAsync(CreateAccountSubTypeInput input);
        Task<AppResponse<bool>> EditAccountSubTypeAsync(long id, EditAccountSubTypeInput input);
        Task<AppResponse<AccountSubTypeDto>> GetAccountSubTypeAsync(long id);
        Task<AppResponse<bool>> ChangeAccountSubTypeStatus (long id, ChangeLookupStatusInput input);
        Task<AppResponse<AccountSubTypesQueryOutput>> GetAccountSubTypesAsync(GetLookupsInput input);

    }
}