using Abp.Domain.Services;
using Abp.Specifications;
using EClinic.AppDomain.Lookups.Models;
using EClinic.AppDomain.Lookups.Models.Bank.Dto;
using EClinic.AppDomain.Lookups.Models.Surgery;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EClinic.AppDomain.Lookups
{
    public partial interface ISystemLookupsManager : IDomainService
    {
        Task<long> CreateSurgeryAsync(CreateSurgeryInput input);
        Task<bool> EditSurgeryAsync(long id, EditSurgeryInput input);
        Task<bool> IsSurgeryExistAsync(string name);
        Task<bool> ChangeSurgeryStatus(long id, ChangeLookupStatusInput input);
        Task<IEnumerable<LookupDto>> SurgeriesQueryAsync(GetLookupsInput input);
        Task<SurgeryDto> GetSurgeryAsync(long id);
    }
}
