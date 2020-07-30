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
        public async Task<AppResponse<long>> CreateSurgeryProcedureAsync(CreateSurgeryProcedureInput input)
        {
            bool isExist = await _systemtLookupsManager.IsSurgeryProcedureExistAsync(input.Name);

            if (isExist)
                return new AppResponse<long>
                {
                    IsSuccessful = false,
                    StatusCode = StatusCodes.ENTITY_ALREADY_EXIST,
                    StatusDescription = string.Format(L("NameExist"), L("SurgeryProcedure"))
                };

            long surgeryId = await _systemtLookupsManager.CreateSurgeryProcedureAsync(input);
            return new AppResponse<long>
            {
                Data = surgeryId,
                IsSuccessful = true,
                StatusCode = StatusCodes.SUCCESS,
                StatusDescription = L("Created")
            };
        }
        public async Task<AppResponse<bool>> EditSurgeryProcedureAsync(long id, EditSurgeryProcedureInput input)
        {
            bool isSurgeryExist = await _systemtLookupsManager.IsSurgeryProcedureExistAsync(input.Name);

            if (isSurgeryExist)
                return new AppResponse<bool>
                {
                    IsSuccessful = false,
                    StatusCode = StatusCodes.ENTITY_ALREADY_EXIST,
                    StatusDescription = string.Format(L("NameExist"), L("SurgeryProcedure"))
                };

            return new AppResponse<bool>
            {
                Data = await _systemtLookupsManager.EditSurgeryProcedureAsync(id, input),
                IsSuccessful = true,
                StatusCode = StatusCodes.SUCCESS,
                StatusDescription = L("Updated")
            };
        }
        public async Task<AppResponse<bool>> ChangeSurgeryProcedureStatus(long id, ChangeLookupStatusInput input)
        {
            bool isChange = await _systemtLookupsManager.ChangeSurgeryProcedureStatus(id, input);

            if (!isChange)
                return new AppResponse<bool>
                {
                    IsSuccessful = false,
                    StatusCode = StatusCodes.ENTITY_ALREADY_EXIST,
                    StatusDescription = string.Format(L("NameExist"), "SurgeryProcedure")
                };

            return new AppResponse<bool>
            {
                Data = true,
                IsSuccessful = true,
                StatusCode = StatusCodes.SUCCESS,
                StatusDescription = L("Created")
            };
        }
        public async Task<AppResponse<SurgeryProceduresQueryOutput>> GetSurgeryProceduresAsync(GetLookupsInput input)
        {

            input.TrimStringProperties();

            IEnumerable<LookupDto> records = await _systemtLookupsManager.SurgeryProceduresQueryAsync(input);

            return new AppResponse<SurgeryProceduresQueryOutput>
            {
                Data = new SurgeryProceduresQueryOutput { SurgeryProcedures = records },
                IsSuccessful = true,
                StatusCode = StatusCodes.SUCCESS
            };
        }
    }
}
