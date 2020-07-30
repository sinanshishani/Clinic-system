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
        public async Task<long> CreatAccountTypeAsync(CreateAccountTypeInput input)
        {
            var record = _mapper.Map<SystemAccountType>(input);
            record.CreatorUserId = GetCurrentUser();

            await _accountTypeRepository.InsertAsync(record);

            await CurrentUnitOfWork.SaveChangesAsync();

            return record.Id;
        }
        [UnitOfWork]
        public async Task<bool> EditAccountTypeAsync(long id, EditAccountTypeInput input)
        {
            var record = await _accountTypeRepository.FirstOrDefaultAsync(x => x.Id == id);

            if (record == null)
                return false;

            _mapper.Map(input, record);
            record.LastModifierUserId = GetCurrentUser();

            await CurrentUnitOfWork.SaveChangesAsync();

            return true;
        }
        public async Task<LookupDto> GetAccountTypeAsync(long id)
        {
            return _accountTypeRepository.GetAll()
                                     .Where(x => x.Id == id)
                                     .Select(x => new LookupDto()
                                     {
                                         Id = x.Id,
                                         Name = x.Name,
                                         Status = x.Status
                                     }).FirstOrDefault();
        }
        [UnitOfWork]
        public async Task<bool> IsAccountTypeExistAsync (string name)
        {
            return await _accountTypeRepository.FirstOrDefaultAsync(x => x.Name == name.Trim()) != null;
        }
        [UnitOfWork]
        public async Task<bool> ChangeAccountTypeStatus(long id, ChangeLookupStatusInput input)
        {
            var record = await _accountTypeRepository.FirstOrDefaultAsync(x => x.Id == id);

            if (record == null)
                return false;

            return await ChangeStatusAsync(record,input.Status);
        }
        public async Task<IEnumerable<LookupDto>> AccountTypesQueryAsync(GetLookupsInput input)
        {
            return await _accountTypeRepository.Query(x => x
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
