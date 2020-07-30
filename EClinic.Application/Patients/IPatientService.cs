using EClinic.Framework.HttpModels;
using EClinic.Core.Patients;
using System.Threading.Tasks;

namespace EClinic.Application.Patients
{
    public interface IPatientService : IApplicationService
    {
        Task<AppResponse> CreatePatientAsync(CreatePatientInput input);
        Task<AppResponse<PatientsQueryOutput>> PatientsQueryAsync(PatientsQueryInput input);
    }
}