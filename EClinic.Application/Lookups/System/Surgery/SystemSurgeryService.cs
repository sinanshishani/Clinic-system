using Abp.Application.Services;
using EClinic.AppDomain.Lookups;
using EClinic.AppDomain.Lookups.Models;
using EClinic.AppDomain.Lookups.Models.Bank.Dto;
using EClinic.AppDomain.Lookups.Models.Surgery;
using EClinic.Core.Lookups;
using EClinic.Framework.HttpModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EClinic.AppServices.Lookups
{
    public partial class SystemLookupsService : ApplicationService, ISystemLookupsService
    {
        public async Task<AppResponse<long>> CreateSurgeryAsync(CreateSurgeryInput input)
        {
            bool isSurgeryExist = await _systemtLookupsManager.IsSurgeryExistAsync(input.Name);

            if (isSurgeryExist)
                return new AppResponse<long>
                {
                    IsSuccessful = false,
                    StatusCode = StatusCodes.ENTITY_ALREADY_EXIST,
                    StatusDescription = L("SurgeryExist")
                };

            long surgeryId = await _systemtLookupsManager.CreateSurgeryAsync(input);
            return new AppResponse<long>
            {
                Data = surgeryId,
                IsSuccessful = true,
                StatusCode = StatusCodes.SUCCESS,
                StatusDescription = L("Created")
            };
        }

        public async Task<AppResponse<bool>>EditSurgeryAsync(long id, EditSurgeryInput input)
        {
            bool isSurgeryExist = await _systemtLookupsManager.IsSurgeryExistAsync(input.Name);

            if (isSurgeryExist)
                return new AppResponse<bool>
                {
                    IsSuccessful = false,
                    StatusCode = StatusCodes.ENTITY_ALREADY_EXIST,
                    StatusDescription = string.Format(L("NameExist"), L("Surgery"))
                };

            return new AppResponse<bool>
            {
                Data = await _systemtLookupsManager.EditSurgeryAsync(id, input),
                IsSuccessful = true,
                StatusCode = StatusCodes.SUCCESS,
                StatusDescription = L("Updated")
            };
        }

        public async Task<AppResponse<bool>> ChangeSurgeryStatus(long id, ChangeLookupStatusInput input)
        {
            bool isChange = await _systemtLookupsManager.ChangeSurgeryStatus(id, input);

            if (!isChange)
                return new AppResponse<bool>
                {
                    IsSuccessful = false,
                    StatusCode = StatusCodes.ENTITY_ALREADY_EXIST,
                    StatusDescription = string.Format(L("NameExist"), "Surgery")
                };

            return new AppResponse<bool>
            {
                Data = true,
                IsSuccessful = true,
                StatusCode = StatusCodes.SUCCESS,
                StatusDescription = L("Created")
            };
        }
        public async Task<AppResponse<SurgeriesQueryOutput>> GetSurgeriesAsync(GetLookupsInput input)
        {

            input.TrimStringProperties();

            IEnumerable<LookupDto> records = await _systemtLookupsManager.SurgeriesQueryAsync(input);

            return new AppResponse<SurgeriesQueryOutput>
            {
                Data = new SurgeriesQueryOutput { Surgeries = records },
                IsSuccessful = true,
                StatusCode = StatusCodes.SUCCESS
            };
        }

        public async Task<AppResponse<SurgeryDto>> GetSurgeryAsync(long id)
        {

            var record = await _systemtLookupsManager.GetSurgeryAsync(id);

            return new AppResponse<SurgeryDto>
            {
                Data = record,
                IsSuccessful = true,
                StatusCode = StatusCodes.SUCCESS
            };
        }

    }
}
