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
        public async Task<AppResponse<long>> CreateMedicalVisitProcedureAsync(CreateMedicalVisitProcedureInput input)
        {
                bool isSurgeryExist = await _systemtLookupsManager.IsMedicalVisitProcedureExistAsync(input.Name);

                if (isSurgeryExist)
                    return new AppResponse<long>
                    {
                        IsSuccessful = false,
                        StatusCode = StatusCodes.ENTITY_ALREADY_EXIST,
                        StatusDescription = L("MedicalVisitProcedureExist")
                    };

                long id = await _systemtLookupsManager.CreateMedicalVisitProcedureAsync(input);
                return new AppResponse<long>
                {
                    Data = id,
                    IsSuccessful = true,
                    StatusCode = StatusCodes.SUCCESS,
                    StatusDescription = L("Created")
                };
           
        }
        public async Task<AppResponse<bool>> EditMedicalVisitProcedureAsync(long id, EditMedicalVisitProcedureInput input)
        {
            try
            {
                bool isSurgeryExist = await _systemtLookupsManager.IsMedicalVisitProcedureExistAsync(input.Name);

                if (isSurgeryExist)
                    return new AppResponse<bool>
                    {
                        IsSuccessful = false,
                        StatusCode = StatusCodes.ENTITY_ALREADY_EXIST,
                        StatusDescription = string.Format(L("NameExist"), L("MedicalVisitProcedure"))
                    };

                return new AppResponse<bool>
                {
                    Data = await _systemtLookupsManager.EditMedicalVisitProcedureAsync(id, input),
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

        public async Task<AppResponse<LookupDto>> GetMedicalVisitProcedureAsync(long id)
        {

           var record = await _systemtLookupsManager.GetMedicalVisitProcedureAsync(id);

            return new AppResponse<LookupDto>
            {
                Data = record,
                IsSuccessful = true,
                StatusCode = StatusCodes.SUCCESS
            };
        }
        public async Task<AppResponse<bool>> ChangeMedicalVisitProcedureStatus(long id, ChangeLookupStatusInput input)
        {
            bool isChange = await _systemtLookupsManager.ChangeMedicalVisitProcedureStatus(id, input);

            if (!isChange)
                return new AppResponse<bool>
                {
                    IsSuccessful = false,
                    StatusCode = StatusCodes.ENTITY_ALREADY_EXIST,
                    StatusDescription = string.Format(L("NameExist"),"MedicalVisitProcedure")
                };

            return new AppResponse<bool>
            {
                Data = true,
                IsSuccessful = true,
                StatusCode = StatusCodes.SUCCESS,
                StatusDescription = L("Created")
            };
        }

        public async Task<AppResponse<MedicalVisitProceduresQueryOutput>> GetMedicalVisitProceduresAsync(GetLookupsInput input)
        {

            input.TrimStringProperties();

            IEnumerable<LookupDto> records = await _systemtLookupsManager.MedicalVisitProceduresQueryAsync(input);

            return new AppResponse<MedicalVisitProceduresQueryOutput>
            {
                Data = new MedicalVisitProceduresQueryOutput { MedicalVisitProcedures = records },
                IsSuccessful = true,
                StatusCode = StatusCodes.SUCCESS
            };
        }
    }
}
