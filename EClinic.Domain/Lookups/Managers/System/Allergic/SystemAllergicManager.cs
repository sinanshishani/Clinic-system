using Abp.Domain.Services;
using Abp.Domain.Uow;
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
        public async Task<long> CreateAllergicAsync(CreateAllergicInput input)
        {
            var record = _mapper.Map<SystemAllergic>(input);
            record.CreatorUserId = GetCurrentUser();

            await _allergicRepository.InsertAsync(record);

            await CurrentUnitOfWork.SaveChangesAsync();

            return record.Id;
        }
        [UnitOfWork]
        public async Task<bool> EditAllergicAsync(long id, EditAllergicInput input)
        {
            var record = await _allergicRepository.FirstOrDefaultAsync(x => x.Id == id);

            if (record == null)
                return false;

            _mapper.Map(input, record);
            record.LastModifierUserId = GetCurrentUser();

            await CurrentUnitOfWork.SaveChangesAsync();

            return true;
        }
        public async Task<LookupDto> GetAllergicAsync(long id)
        {
            return _allergicRepository.GetAll()
                                     .Where(x => x.Id == id)
                                     .Select(x => new LookupDto()
                                     {
                                         Id = x.Id,
                                         Name = x.Name,
                                         Status = x.Status
                                     }).FirstOrDefault();
        }
        [UnitOfWork]
        public async Task<bool> IsAllergicExistAsync(string name)
        {
            return await _allergicRepository.FirstOrDefaultAsync(x => x.Name == name.Trim()) != null;
        }
        [UnitOfWork]
        public async Task<bool> ChangeAllergicStatus(long id, ChangeLookupStatusInput input)
        {
            var record = await _allergicRepository.FirstOrDefaultAsync(x => x.Id == id);

            if (record == null)
                return false;

            return await ChangeStatusAsync(record, input.Status);
        }
        public async Task<IEnumerable<LookupDto>> AllergiesQueryAsync(GetLookupsInput input)
        {
            return await _allergicRepository.Query(x => x
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
