using Abp.Application.Services;
using EClinic.AppDomain.Lookups;
using EClinic.AppDomain.Lookups.Models;
using EClinic.AppDomain.Lookups.Models.Bank.Dto;
using EClinic.Core.Lookups;
using EClinic.Framework.HttpModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EClinic.AppServices.Lookups
{
    public partial class SystemLookupsService : ApplicationService, ISystemLookupsService
    {
        public async Task<AppResponse<long>> CreateDiagnosisAsync(CreateDiagnosisInput input)
        {
            try
            {
                bool isAlreadyExist = await _systemtLookupsManager.IsDiagnosisExistAsync(input.Name);

                if (isAlreadyExist)
                    return new AppResponse<long>
                    {
                        IsSuccessful = false,
                        StatusCode = StatusCodes.ENTITY_ALREADY_EXIST,
                        StatusDescription = string.Format(L("NameExist"), "Diagnosis")
                    };

                long id = await _systemtLookupsManager.CreateDiagnosisAsync(input);
                return new AppResponse<long>
                {
                    Data = id,
                    IsSuccessful = true,
                    StatusCode = StatusCodes.SUCCESS,
                    StatusDescription = L("Created")
                };
            }
            catch (System.Exception ex)
            {

                throw;
            }
        }
        public async Task<AppResponse<bool>> EditDiagnosisAsync(long id, EditDiagnosisInput input)
        {
            try
            {
                bool isSurgeryExist = await _systemtLookupsManager.IsDiagnosisExistAsync(input.Name);

                if (isSurgeryExist)
                    return new AppResponse<bool>
                    {
                        IsSuccessful = false,
                        StatusCode = StatusCodes.ENTITY_ALREADY_EXIST,
                        StatusDescription = string.Format(L("NameExist"), L("Diagnosis"))
                    };

                return new AppResponse<bool>
                {
                    Data = await _systemtLookupsManager.EditDiagnosisAsync(id, input),
                    IsSuccessful = true,
                    StatusCode = StatusCodes.SUCCESS,
                    StatusDescription = L("Updated")
                };
            }
            catch (System.Exception ex)
            {

                throw;
            }
        }

        public async Task<AppResponse<LookupDto>> GetDiagnosisAsync(long id)
        {

            var record = await _systemtLookupsManager.GetDiagnosisAsync(id);

            return new AppResponse<LookupDto>
            {
                Data = record,
                IsSuccessful = true,
                StatusCode = StatusCodes.SUCCESS
            };
        }

        public async Task<AppResponse<bool>> ChangeDiagnosisStatus(long id, ChangeLookupStatusInput input)
        {
            bool isChange = await _systemtLookupsManager.ChangeDiagnosisStatus(id, input);

            if (!isChange)
                return new AppResponse<bool>
                {
                    IsSuccessful = false,
                    StatusCode = StatusCodes.ENTITY_ALREADY_EXIST,
                    StatusDescription = L("SurgeryExist")
                };

            return new AppResponse<bool>
            {
                Data = true,
                IsSuccessful = true,
                StatusCode = StatusCodes.SUCCESS,
                StatusDescription = L("Created")
            };
        }

        public async Task<AppResponse<DiagnosisQueryOutput>> GetDiagnosesAsync(GetLookupsInput input)
        {

            input.TrimStringProperties();

            IEnumerable<LookupDto> records = await _systemtLookupsManager.DiagnosesQueryAsync(input);

            return new AppResponse<DiagnosisQueryOutput>
            {
                Data = new DiagnosisQueryOutput { Diagnoses = records },
                IsSuccessful = true,
                StatusCode = StatusCodes.SUCCESS
            };
        }
    }
}
