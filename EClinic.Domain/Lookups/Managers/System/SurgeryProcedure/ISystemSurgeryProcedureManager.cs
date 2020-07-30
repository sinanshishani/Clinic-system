using Abp.Domain.Services;
using Abp.Specifications;
using EClinic.AppDomain.Lookups.Models;
using EClinic.AppDomain.Lookups.Models.Bank.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EClinic.AppDomain.Lookups
{
    public partial interface ISystemLookupsManager : IDomainService
    {
        Task<long> CreateSurgeryProcedureAsync(CreateSurgeryProcedureInput input);
        Task<bool> EditSurgeryProcedureAsync(long id, EditSurgeryProcedureInput input);
        Task<bool> IsSurgeryProcedureExistAsync(string name);
        Task<bool> ChangeSurgeryProcedureStatus(long id, ChangeLookupStatusInput input);
        Task<IEnumerable<LookupDto>> SurgeryProceduresQueryAsync(GetLookupsInput input);
    }
}
