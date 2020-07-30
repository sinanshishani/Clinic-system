using Abp.Application.Services;
using EClinic.AppDomain.Lookups;
using EClinic.AppDomain.Lookups.Models;
using EClinic.Core.Lookups;
using EClinic.Framework.HttpModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EClinic.AppServices.Lookups
{
    public partial class SystemLookupsService : ApplicationService, ISystemLookupsService
    {
        public async Task<AppResponse<long>> CreateAccountSubTypeAsync(CreateAccountSubTypeInput input)
        {

            bool isSurgeryExist = await _systemtLookupsManager.IsAccountSubTypeExistAsync(input.Name);

            if (isSurgeryExist)
                return new AppResponse<long>
                {
                    IsSuccessful = false,
                    StatusCode = StatusCodes.ENTITY_ALREADY_EXIST,
                    StatusDescription = L("AccountSubTypeExist")
                };

            long id = await _systemtLookupsManager.CreateAccountSubTypeAsync(input);
            return new AppResponse<long>
            {
                Data = id,
                IsSuccessful = true,
                StatusCode = StatusCodes.SUCCESS,
                StatusDescription = L("Created")
            };

        }
        public async Task<AppResponse<bool>> EditAccountSubTypeAsync(long id, EditAccountSubTypeInput input)
        {

            bool isSurgeryExist = await _systemtLookupsManager.IsAccountSubTypeExistAsync(input.Name);

            if (isSurgeryExist)
                return new AppResponse<bool>
                {
                    IsSuccessful = false,
                    StatusCode = StatusCodes.ENTITY_ALREADY_EXIST,
                    StatusDescription = string.Format(L("NameExist"), L("AccountSubType"))
                };

            return new AppResponse<bool>
            {
                Data = await _systemtLookupsManager.EditAccountSubTypeAsync(id, input),
                IsSuccessful = true,
                StatusCode = StatusCodes.SUCCESS,
                StatusDescription = L("Updated")
            };

        }

        public async Task<AppResponse<AccountSubTypeDto>> GetAccountSubTypeAsync(long id)
        {

            var record = await _systemtLookupsManager.GetAccountSubTypeAsync(id);

            return new AppResponse<AccountSubTypeDto>
            {
                Data = record,
                IsSuccessful = true,
                StatusCode = StatusCodes.SUCCESS
            };
        }
        public async Task<AppResponse<bool>> ChangeAccountSubTypeStatus(long id, ChangeLookupStatusInput input)
        {
            bool isChange = await _systemtLookupsManager.ChangeAccountSubTypeStatus(id, input);

            if (!isChange)
                return new AppResponse<bool>
                {
                    IsSuccessful = false,
                    StatusCode = StatusCodes.ENTITY_ALREADY_EXIST,
                    StatusDescription = string.Format(L("NameExist"), "AccountSubType")
                };

            return new AppResponse<bool>
            {
                Data = true,
                IsSuccessful = true,
                StatusCode = StatusCodes.SUCCESS,
                StatusDescription = L("Created")
            };
        }

        public async Task<AppResponse<AccountSubTypesQueryOutput>> GetAccountSubTypesAsync(GetLookupsInput input)
        {

            input.TrimStringProperties();

            IEnumerable<AccountSubTypeDto> records = await _systemtLookupsManager.AccountSubTypesQueryAsync(input);

            return new AppResponse<AccountSubTypesQueryOutput>
            {
                Data = new AccountSubTypesQueryOutput { AccountSubTypes = records },
                IsSuccessful = true,
                StatusCode = StatusCodes.SUCCESS
            };
        }
    }
}
