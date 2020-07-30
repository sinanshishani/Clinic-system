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
        public async Task<AppResponse<long>> CreateAccountTypeAsync(CreateAccountTypeInput input)
        {

                bool isSurgeryExist = await _systemtLookupsManager.IsAccountTypeExistAsync(input.Name);

                if (isSurgeryExist)
                    return new AppResponse<long>
                    {
                        IsSuccessful = false,
                        StatusCode = StatusCodes.ENTITY_ALREADY_EXIST,
                        StatusDescription = L("AccountTypeExist")
                    };

                long id = await _systemtLookupsManager.CreatAccountTypeAsync(input);
                return new AppResponse<long>
                {
                    Data = id,
                    IsSuccessful = true,
                    StatusCode = StatusCodes.SUCCESS,
                    StatusDescription = L("Created")
                };
           
        }
        public async Task<AppResponse<bool>> EditAccountTypeAsync(long id, EditAccountTypeInput input)
        {

                bool isSurgeryExist = await _systemtLookupsManager.IsAccountTypeExistAsync(input.Name);

                if (isSurgeryExist)
                    return new AppResponse<bool>
                    {
                        IsSuccessful = false,
                        StatusCode = StatusCodes.ENTITY_ALREADY_EXIST,
                        StatusDescription = string.Format(L("NameExist"), L("AccountType"))
                    };

                return new AppResponse<bool>
                {
                    Data = await _systemtLookupsManager.EditAccountTypeAsync(id, input),
                    IsSuccessful = true,
                    StatusCode = StatusCodes.SUCCESS,
                    StatusDescription = L("Updated")
                };
 
        }

        public async Task<AppResponse<LookupDto>> GetAccountTypeAsync(long id)
        {

           var record = await _systemtLookupsManager.GetAccountTypeAsync(id);

            return new AppResponse<LookupDto>
            {
                Data = record,
                IsSuccessful = true,
                StatusCode = StatusCodes.SUCCESS
            };
        }
        public async Task<AppResponse<bool>> ChangeAccountTypeStatus(long id, ChangeLookupStatusInput input)
        {
            bool isChange = await _systemtLookupsManager.ChangeAccountTypeStatus(id, input);

            if (!isChange)
                return new AppResponse<bool>
                {
                    IsSuccessful = false,
                    StatusCode = StatusCodes.ENTITY_ALREADY_EXIST,
                    StatusDescription = string.Format(L("NameExist"),"AccountType")
                };

            return new AppResponse<bool>
            {
                Data = true,
                IsSuccessful = true,
                StatusCode = StatusCodes.SUCCESS,
                StatusDescription = L("Created")
            };
        }

        public async Task<AppResponse<AccountTypesQueryOutput>> GetAccountTypesAsync(GetLookupsInput input)
        {

            input.TrimStringProperties();

            IEnumerable<LookupDto> records = await _systemtLookupsManager.AccountTypesQueryAsync(input);

            return new AppResponse<AccountTypesQueryOutput>
            {
                Data = new AccountTypesQueryOutput { AccountTypes = records },
                IsSuccessful = true,
                StatusCode = StatusCodes.SUCCESS
            };
        }
    }
}
