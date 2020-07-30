using Abp.Specifications;
using AutoMapper;
using EClinic.Domain.Patients;
using EClinic.Framework.HttpModels;
using EClinic.Core.Patients;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EClinic.Application.Patients
{
    public class PatientService : IPatientService
    {
        private readonly IPatienManager _patienManager;
        private readonly IMapper _mapper;

        public PatientService(IPatienManager patienManager, IMapper mapper)
        {
            _patienManager = patienManager;
            _mapper = mapper;
        }

        public async Task<AppResponse> CreatePatientAsync(CreatePatientInput input)
        {
            bool isPatientExist = await _patienManager.IsPatientExistAsync(new PatientIdNumberSpecification(input.IdNumber)
                .Or(new PatientProfileNumberSpecification(input.ProfileNumber)));

            if (isPatientExist)
                return new AppResponse
                {
                    IsSuccessful = false,
                    StatusCode = StatusCodes.ENTITY_ALREADY_EXIST,
                    StatusDescription = "Patient is already registered on the system"
                };

            await _patienManager.CreatePatientAsync(input);

            return new AppResponse
            {
                IsSuccessful = true,
                StatusCode = StatusCodes.SUCCESS,
                StatusDescription = "Patient has been created successfully"
            };
        }

        public async Task<AppResponse<PatientsQueryOutput>> PatientsQueryAsync(PatientsQueryInput input)
        {
            input.TrimStringProperties();

            IEnumerable<PatientQueryDto> patients = await _patienManager.PatientsQueryAsync(input);

            return new AppResponse<PatientsQueryOutput>
            { 
                Data = new PatientsQueryOutput { Patients = patients },
                IsSuccessful = true,
                StatusCode = StatusCodes.SUCCESS
            };
        }
    }
}
