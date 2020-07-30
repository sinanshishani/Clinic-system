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
        public async Task<AppResponse<long>> CreateComplaintAsync(CreateComplaintInput input)
        {

                bool isSurgeryExist = await _systemtLookupsManager.IsComplaintExistAsync(input.Name);

                if (isSurgeryExist)
                    return new AppResponse<long>
                    {
                        IsSuccessful = false,
                        StatusCode = StatusCodes.ENTITY_ALREADY_EXIST,
                        StatusDescription = L("ComplaintExist")
                    };

                long id = await _systemtLookupsManager.CreatComplaintAsync(input);
                return new AppResponse<long>
                {
                    Data = id,
                    IsSuccessful = true,
                    StatusCode = StatusCodes.SUCCESS,
                    StatusDescription = L("Created")
                };

        }

        public async Task<AppResponse<bool>> EditComplaintAsync(long id, EditComplaintInput input)
        {
            try
            {
                bool isSurgeryExist = await _systemtLookupsManager.IsComplaintExistAsync(input.Name);

                if (isSurgeryExist)
                    return new AppResponse<bool>
                    {
                        IsSuccessful = false,
                        StatusCode = StatusCodes.ENTITY_ALREADY_EXIST,
                        StatusDescription = string.Format(L("NameExist"), L("Complaint"))
                    };

                return new AppResponse<bool>
                {
                    Data = await _systemtLookupsManager.EditComplaintAsync(id, input),
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

        public async Task<AppResponse<LookupDto>> GetComplaintAsync(long id)
        {

            var record = await _systemtLookupsManager.GetComplaintAsync(id);

            return new AppResponse<LookupDto>
            {
                Data = record,
                IsSuccessful = true,
                StatusCode = StatusCodes.SUCCESS
            };
        }
        public async Task<AppResponse<bool>> ChangeComplaintStatus(long id, ChangeLookupStatusInput input)
        {
            bool isChange = await _systemtLookupsManager.ChangeComplaintStatus(id, input);

            if (!isChange)
                return new AppResponse<bool>
                {
                    IsSuccessful = false,
                    StatusCode = StatusCodes.ENTITY_ALREADY_EXIST,
                    StatusDescription = string.Format(L("NameExist"),"Complaint")
                };

            return new AppResponse<bool>
            {
                Data = true,
                IsSuccessful = true,
                StatusCode = StatusCodes.SUCCESS,
                StatusDescription = L("Created")
            };
        }

        public async Task<AppResponse<ComplaintsQueryOutput>> GetComplaintsAsync(GetLookupsInput input)
        {

            input.TrimStringProperties();

            IEnumerable<LookupDto> records = await _systemtLookupsManager.ComplaintsQueryAsync(input);

            return new AppResponse<ComplaintsQueryOutput>
            {
                Data = new ComplaintsQueryOutput { Complaints = records },
                IsSuccessful = true,
                StatusCode = StatusCodes.SUCCESS
            };
        }
    }
}
