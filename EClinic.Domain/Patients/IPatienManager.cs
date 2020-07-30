using Abp.Specifications;
using EClinic.Core.Patients;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EClinic.Domain.Patients
{
    public interface IPatienManager : IDomainService
    {
        Task<long> CreatePatientAsync(CreatePatientInput input);
        Task<bool> IsPatientExistAsync(ISpecification<PatientProfile> spec);
        Task<IEnumerable<PatientQueryDto>> PatientsQueryAsync(PatientsQueryInput input);
    }
}