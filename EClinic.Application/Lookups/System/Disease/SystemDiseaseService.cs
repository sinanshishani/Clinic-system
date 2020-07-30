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
        public async Task<AppResponse<long>> CreateDiseaseAsync(CreateDiseaseInput input)
        {

                bool isSurgeryExist = await _systemtLookupsManager.IsDiseaseExistAsync(input.Name);

                if (isSurgeryExist)
                    return new AppResponse<long>
                    {
                        IsSuccessful = false,
                        StatusCode = StatusCodes.ENTITY_ALREADY_EXIST,
                        StatusDescription = string.Format(L("NameExist"), "Disease")
                    };

                long id = await _systemtLookupsManager.CreateDiseaseAsync(input);
                return new AppResponse<long>
                {
                    Data = id,
                    IsSuccessful = true,
                    StatusCode = StatusCodes.SUCCESS,
                    StatusDescription = L("Created")
                };
        }
        public async Task<AppResponse<bool>> EditDiseaseAsync(long id, EditDiseaseInput input)
        {
            try
            {
                bool isSurgeryExist = await _systemtLookupsManager.IsDiseaseExistAsync(input.Name);

                if (isSurgeryExist)
                    return new AppResponse<bool>
                    {
                        IsSuccessful = false,
                        StatusCode = StatusCodes.ENTITY_ALREADY_EXIST,
                        StatusDescription = string.Format(L("NameExist"), L("Disease"))
                    };

                return new AppResponse<bool>
                {
                    Data = await _systemtLookupsManager.EditDiseaseAsync(id, input),
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

        public async Task<AppResponse<LookupDto>> GetDiseaseAsync(long id)
        {

            var record = await _systemtLookupsManager.GetDiseaseAsync(id);

            return new AppResponse<LookupDto>
            {
                Data = record,
                IsSuccessful = true,
                StatusCode = StatusCodes.SUCCESS
            };
        }
        public async Task<AppResponse<bool>> ChangeDiseaseStatus(long id, ChangeLookupStatusInput input)
        {
            bool isChange = await _systemtLookupsManager.ChangeDiseaseStatus(id, input);

            if (!isChange)
                return new AppResponse<bool>
                {
                    IsSuccessful = false,
                    StatusCode = StatusCodes.ENTITY_ALREADY_EXIST,
                    StatusDescription = string.Format(L("NameExist"),"Disease")
                };

            return new AppResponse<bool>
            {
                Data = true,
                IsSuccessful = true,
                StatusCode = StatusCodes.SUCCESS,
                StatusDescription = L("Created")
            };
        }

        public async Task<AppResponse<DiseasesQueryOutput>> GetDiseasesAsync(GetLookupsInput input)
        {

            input.TrimStringProperties();

            IEnumerable<LookupDto> records = await _systemtLookupsManager.DiseasesQueryAsync(input);

            return new AppResponse<DiseasesQueryOutput>
            {
                Data = new DiseasesQueryOutput { Diseases = records },
                IsSuccessful = true,
                StatusCode = StatusCodes.SUCCESS
            };
        }
    }
}
