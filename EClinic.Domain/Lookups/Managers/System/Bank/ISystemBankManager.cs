using Abp.Domain.Services;
using EClinic.AppDomain.Lookups.Models;
using EClinic.AppDomain.Lookups.Models.Bank.Dto;
using EClinic.Enums;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EClinic.AppDomain.Lookups
{
    public partial interface ISystemLookupsManager : IDomainService
    {
        Task<long> CreateBankAsync(CreateBankInput input);
        Task<bool> EditBankAsync(long id, EditBankInput input);
        Task<LookupDto> GetBankAsync(long id);
        Task<bool> IsBankExistAsync(string name);
    
        Task<bool> ChangeBankStatus(long id, ChangeLookupStatusInput input);
        Task<IEnumerable<LookupDto>> BanksQueryAsync (GetLookupsInput input);

    }
}
