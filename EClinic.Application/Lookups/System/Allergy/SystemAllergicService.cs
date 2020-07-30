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
        public async Task<AppResponse<long>> CreateAllergicAsync(CreateAllergicInput input)
        {
                bool isSurgeryExist = await _systemtLookupsManager.IsAllergicExistAsync(input.Name);

                if (isSurgeryExist)
                    return new AppResponse<long>
                    {
                        IsSuccessful = false,
                        StatusCode = StatusCodes.ENTITY_ALREADY_EXIST,
                        StatusDescription = L("AllergicExist")
                    };

                long id = await _systemtLookupsManager.CreateAllergicAsync(input);
                return new AppResponse<long>
                {
                    Data = id,
                    IsSuccessful = true,
                    StatusCode = StatusCodes.SUCCESS,
                    StatusDescription = L("Created")
                };
        }
        public async Task<AppResponse<bool>> EditAllergicAsync(long id, EditAllergicInput input)
        {
                bool isSurgeryExist = await _systemtLookupsManager.IsAllergicExistAsync(input.Name);

                if (isSurgeryExist)
                    return new AppResponse<bool>
                    {
                        IsSuccessful = false,
                        StatusCode = StatusCodes.ENTITY_ALREADY_EXIST,
                        StatusDescription = string.Format(L("NameExist"), L("Allergic"))
                    };

                return new AppResponse<bool>
                {
                    Data = await _systemtLookupsManager.EditAllergicAsync(id, input),
                    IsSuccessful = true,
                    StatusCode = StatusCodes.SUCCESS,
                    StatusDescription = L("Updated")
                };
        }

        public async Task<AppResponse<LookupDto>> GetAllergicAsync(long id)
        {

           var record = await _systemtLookupsManager.GetAllergicAsync(id);

            return new AppResponse<LookupDto>
            {
                Data = record,
                IsSuccessful = true,
                StatusCode = StatusCodes.SUCCESS
            };
        }
        public async Task<AppResponse<bool>> ChangeAllergicStatus(long id, ChangeLookupStatusInput input)
        {
            bool isChange = await _systemtLookupsManager.ChangeAllergicStatus(id, input);

            if (!isChange)
                return new AppResponse<bool>
                {
                    IsSuccessful = false,
                    StatusCode = StatusCodes.ENTITY_ALREADY_EXIST,
                    StatusDescription = string.Format(L("NameExist"),"Allergic")
                };

            return new AppResponse<bool>
            {
                Data = true,
                IsSuccessful = true,
                StatusCode = StatusCodes.SUCCESS,
                StatusDescription = L("Created")
            };
        }

        public async Task<AppResponse<AllergiesQueryOutput>> GetAllergiesAsync(GetLookupsInput input)
        {

            input.TrimStringProperties();

            IEnumerable<LookupDto> records = await _systemtLookupsManager.AllergiesQueryAsync(input);

            return new AppResponse<AllergiesQueryOutput>
            {
                Data = new AllergiesQueryOutput { Allergies = records },
                IsSuccessful = true,
                StatusCode = StatusCodes.SUCCESS
            };
        }
    }
}
