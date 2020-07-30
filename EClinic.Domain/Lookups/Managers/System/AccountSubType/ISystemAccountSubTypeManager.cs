using Abp.Domain.Services;
using EClinic.AppDomain.Lookups.Models;
using EClinic.Core.Lookups;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EClinic.AppDomain.Lookups
{
    public partial interface ISystemLookupsManager : IDomainService
    {
        Task<long> CreateAccountSubTypeAsync(CreateAccountSubTypeInput input);
        Task<bool> EditAccountSubTypeAsync(long id, EditAccountSubTypeInput input);
        Task<AccountSubTypeDto> GetAccountSubTypeAsync(long id);
        Task<bool> IsAccountSubTypeExistAsync(string name);
    
        Task<bool> ChangeAccountSubTypeStatus(long id, ChangeLookupStatusInput input);
        Task<IEnumerable<AccountSubTypeDto>> AccountSubTypesQueryAsync (GetLookupsInput input);

    }
}
