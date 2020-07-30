using Abp.Domain.Services;
using EClinic.AppDomain.Lookups.Models;
using EClinic.AppDomain.Lookups.Models.Bank.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EClinic.AppDomain.Lookups
{
    public partial interface ISystemLookupsManager : IDomainService
    {
        Task<long> CreateMedicalVisitProcedureAsync(CreateMedicalVisitProcedureInput input);
        Task<bool> EditMedicalVisitProcedureAsync(long id, EditMedicalVisitProcedureInput input);
        Task<LookupDto> GetMedicalVisitProcedureAsync(long id);
        Task<bool> IsMedicalVisitProcedureExistAsync(string name);
    
        Task<bool> ChangeMedicalVisitProcedureStatus(long id, ChangeLookupStatusInput input);
        Task<IEnumerable<LookupDto>> MedicalVisitProceduresQueryAsync (GetLookupsInput input);

    }
}
