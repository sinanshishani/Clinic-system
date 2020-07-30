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
        Task<long> CreateDiseaseAsync(CreateDiseaseInput input);
        Task<bool> EditDiseaseAsync(long id, EditDiseaseInput input);
        Task<LookupDto> GetDiseaseAsync(long id);
        Task<bool> IsDiseaseExistAsync(string name);
        Task<bool> ChangeDiseaseStatus(long id, ChangeLookupStatusInput input);
        Task<IEnumerable<LookupDto>> DiseasesQueryAsync(GetLookupsInput input);

    }
}
