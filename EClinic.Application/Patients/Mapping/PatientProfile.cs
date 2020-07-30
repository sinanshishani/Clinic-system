using AutoMapper;
using EClinic.Core.Patients;

namespace EClinic.Application.Patients.Mapping
{
    public class PatientProfile : Profile
    {
        public PatientProfile()
        {
            MapCreatPatientInputToPatient();
        }

        private void MapCreatPatientInputToPatient()
        {
            CreateMap<CreatePatientInput, PatientProfile>();
                //.ForPath(d => d.Insurance.InsuranceNumber, opt => opt.MapFrom(s => s.InsuranceNumber))
                //.ForPath(d => d.Insurance.ExpiryDate, opt => opt.MapFrom(s => s.ExpiryDate))
                //.ForPath(d => d.Insurance.MedicalVisitPayloadRate, opt => opt.MapFrom(s => s.MedicalVisitPayloadRatio))
                //.ForPath(d => d.Insurance.MedicalProceduresPayloadRate, opt => opt.MapFrom(s => s.MedicalProceduresPayloadRatio))
                //.ForPath(d => d.Insurance.StartDate, opt => opt.MapFrom(s => s.StartDate))
                //.ForPath(d => d.Insurance.Notes, opt => opt.MapFrom(s => s.Notes))
                //.ForPath(d => d.Insurance.InsuranceCompanyId, opt => opt.MapFrom(s => s.InsuranceCompanyId));
        }
    }
}