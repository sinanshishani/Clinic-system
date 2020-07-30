using Abp.Domain.Services;
using EClinic.AppDomain.Lookups.Models;
using EClinic.AppDomain.Lookups.Models.Bank.Dto;
using EClinic.Enums;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EClinic.AppDomain.Lookups
{
    public partial interface ISystemLookupsManager : IDomainService
    {
        Task<long> CreatComplaintAsync(CreateComplaintInput input);
        Task<bool> EditComplaintAsync(long id, EditComplaintInput input);
        Task<LookupDto> GetComplaintAsync(long id);
        Task<bool> IsComplaintExistAsync(string name);
        Task<bool> ChangeComplaintStatus(long id, ChangeLookupStatusInput input);
        Task<IEnumerable<LookupDto>> ComplaintsQueryAsync(GetLookupsInput input);

    }
}
