using Abp.Domain.Services;
using Abp.Domain.Uow;
using Abp.Runtime.Session;
using EClinic.AppDomain.Lookups.Models;
using EClinic.AppDomain.Lookups.Models.Bank.Dto;
using EClinic.Domain.Lookups;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EClinic.AppDomain.Lookups
{
    public partial class SystemLookupsManager : DomainService, ISystemLookupsManager
    {
        [UnitOfWork]
        public async Task<long> CreatComplaintAsync(CreateComplaintInput input)
        {
            var record = _mapper.Map<SystemComplaint>(input);
            record.CreatorUserId = _abpSession.GetUserId();

            await _complaintRepository.InsertAsync(record);

            await CurrentUnitOfWork.SaveChangesAsync();

            return record.Id;
        }
        [UnitOfWork]
        public async Task<bool> EditComplaintAsync(long id, EditComplaintInput input)
        {
            var record = await _complaintRepository.FirstOrDefaultAsync(x => x.Id == id);

            if (record == null)
                return false;

            _mapper.Map(input, record);
            record.LastModifierUserId = GetCurrentUser();

            await CurrentUnitOfWork.SaveChangesAsync();

            return true;
        }
        public async Task<LookupDto> GetComplaintAsync(long id)
        {
            return _complaintRepository.GetAll()
                                     .Where(x => x.Id == id)
                                     .Select(x => new LookupDto()
                                     {
                                         Id = x.Id,
                                         Name = x.Name,
                                         Status = x.Status
                                     }).FirstOrDefault();
        }
        [UnitOfWork]
        public async Task<bool> IsComplaintExistAsync(string name)
        {
            return await _complaintRepository.FirstOrDefaultAsync(x => x.Name == name.Trim()) != null;
        }
        [UnitOfWork]
        public async Task<bool> ChangeComplaintStatus (long id, ChangeLookupStatusInput input)
        {
            var record = await _complaintRepository.FirstOrDefaultAsync(x => x.Id == id);

            if (record == null)
                return false;

            return await ChangeStatusAsync(record,input.Status);
        }
        public async Task<IEnumerable<LookupDto>> ComplaintsQueryAsync(GetLookupsInput input)
        {
            return await _complaintRepository.Query(x => x
                                 .Where(p => p.IsDeleted == input.DeletedOnly)
                                 .Skip(input.SkipCount)
                                 .Take(input.MaxResultCount)
                                 .Select(x => new LookupDto()
                                 {
                                     Id = x.Id,
                                     Name = x.Name,
                                     Status = x.Status
                                 }).ToListAsync());
        }
    }
}
