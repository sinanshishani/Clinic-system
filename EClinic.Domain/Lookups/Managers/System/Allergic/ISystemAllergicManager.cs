using Abp.Domain.Services;
using EClinic.AppDomain.Lookups.Models;
using EClinic.AppDomain.Lookups.Models.Bank.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EClinic.AppDomain.Lookups
{
    public partial interface ISystemLookupsManager : IDomainService
    {
        Task<long> CreateAllergicAsync(CreateAllergicInput input);
        Task<bool> EditAllergicAsync(long id, EditAllergicInput input);
        Task<LookupDto> GetAllergicAsync(long id);
        Task<bool> IsAllergicExistAsync(string name);
    
        Task<bool> ChangeAllergicStatus(long id, ChangeLookupStatusInput input);
        Task<IEnumerable<LookupDto>> AllergiesQueryAsync (GetLookupsInput input);

    }
}
