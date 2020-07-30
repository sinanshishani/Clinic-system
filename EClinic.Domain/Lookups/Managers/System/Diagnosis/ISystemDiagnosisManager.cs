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
        Task<long> CreateDiagnosisAsync(CreateDiagnosisInput input);
        Task<bool> EditDiagnosisAsync(long id, EditDiagnosisInput input);
        Task<LookupDto> GetDiagnosisAsync(long id);
        Task<bool> IsDiagnosisExistAsync(string name);
        Task<bool> ChangeDiagnosisStatus(long id, ChangeLookupStatusInput input);
        Task<IEnumerable<LookupDto>> DiagnosesQueryAsync (GetLookupsInput input);

    }
}
