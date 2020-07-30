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
        Task<long> CreatAccountTypeAsync(CreateAccountTypeInput input);
        Task<bool> EditAccountTypeAsync(long id, EditAccountTypeInput input);
        Task<LookupDto> GetAccountTypeAsync(long id);
        Task<bool> IsAccountTypeExistAsync(string name);
        Task<bool> ChangeAccountTypeStatus(long id, ChangeLookupStatusInput input);
        Task<IEnumerable<LookupDto>> AccountTypesQueryAsync (GetLookupsInput input);

    }
}
