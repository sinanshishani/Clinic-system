using Abp.Specifications;
using AutoMapper;
using EClinic.Framework.Repositories;
using EClinic.Core.Patients;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EClinic.Domain.Patients
{
    public class PatienManager : IPatienManager
    {
        private readonly IRepository<PatientProfile, long> _patientrepository;
        private readonly IMapper _mapper;

        public PatienManager(IRepository<PatientProfile, long> patientrepository, IMapper mapper)
        {
            _patientrepository = patientrepository;
            _mapper = mapper;
        }

        public async Task<long> CreatePatientAsync(CreatePatientInput input)
        {
            PatientProfile patient = _mapper.Map<PatientProfile>(input);
            long patientId = await _patientrepository.InsertAndGetIdAsync(patient);
            return patientId;
        }

        public async Task<bool> IsPatientExistAsync(ISpecification<PatientProfile> spec)
        {
            PatientProfile patient = await _patientrepository.SingleAsync(spec.ToExpression());
            return patient != null;
        }

        public async Task<IEnumerable<PatientQueryDto>> PatientsQueryAsync(PatientsQueryInput input)
        {
            IEnumerable<PatientProfile> queryPatients = await _patientrepository.Query(patients => 
                patients.Include(p => p.Insurance)
                            .ThenInclude(i => i.InsuranceCompany)
                       .Where(p => 
                            (p.Id == input.PatientId || input.PatientId == 0)
                         && (p.IdNumber.Contains(input.IdNumber) || string.IsNullOrEmpty(input.IdNumber))
                         && (p.Name.ToLower().Contains(input.Name.ToLower()) || string.IsNullOrEmpty(input.Name))
                         && (p.ProfileNumber.Contains(input.ProfileNumber) || string.IsNullOrEmpty(input.ProfileNumber))
                         && (p.PhoneNumber.Contains(input.PhoneNumber) || string.IsNullOrEmpty(input.PhoneNumber))
                         && (p.Email.Contains(input.Email) || string.IsNullOrEmpty(input.Email))
                         && (p.DoctorId == input.DoctorId || input.DoctorId == 0)
                         && (p.Insurance.InsuranceCompanyId == input.InsuranceCompanyId || input.InsuranceCompanyId == 0)
                         && (p.HasHealthInsurance == input.HasHealthInsurance || input.HasHealthInsurance == false)
                       )
                       .Skip(input.SkipCount)
                       .Take(input.MaxResultCount)
                       .ToListAsync()
                );

            IEnumerable<PatientQueryDto> patientQueryDtos = _mapper.Map<IEnumerable<PatientQueryDto>>(queryPatients);
            return patientQueryDtos;
        }
    }
}