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
        Task<AppResponse<long>> CreateBankAsync(CreateBankInput input);
        Task<AppResponse<bool>> EditBankAsync(long id ,EditBankInput input);
        Task<AppResponse<LookupDto>> GetBankAsync(long id);
        Task<AppResponse<bool>> ChangeBankStatus (long id ,ChangeLookupStatusInput input);
        Task<AppResponse<BanksQueryOutput>> GetBanksAsync(GetLookupsInput input);

    }
}