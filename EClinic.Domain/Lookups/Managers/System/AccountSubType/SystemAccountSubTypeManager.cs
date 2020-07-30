using Abp.Domain.Services;
using Abp.Domain.Uow;
using EClinic.AppDomain.Lookups.Models;
using EClinic.AppDomain.Lookups.Models.Bank.Dto;
using EClinic.Core.Lookups;
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
        public async Task<long> CreateAccountSubTypeAsync(CreateAccountSubTypeInput input)
        {
            var accountType = _accountTypeRepository.FirstOrDefault(x => x.Id == input.AccountTypeId);

            if (accountType == null)
                return 0;

            var record = _mapper.Map<SystemAccountSubType>(input);
                 record.CreatorUserId = GetCurrentUser();

            await _accountSubTypeRepository.InsertAsync(record);

            await CurrentUnitOfWork.SaveChangesAsync();

            return record.Id;
        }
        [UnitOfWork]
        public async Task<bool> EditAccountSubTypeAsync(long id, EditAccountSubTypeInput input)
        {
            var record = await _accountSubTypeRepository.FirstOrDefaultAsync(x => x.Id == id);

            if (record == null)
                return false;

            _mapper.Map(input, record);
            record.LastModifierUserId = GetCurrentUser();

            await CurrentUnitOfWork.SaveChangesAsync();

            return true;
        }
        public async Task<AccountSubTypeDto> GetAccountSubTypeAsync(long id)
        {
            return _accountSubTypeRepository.GetAll()
                                     .Where(x => x.Id == id)
                                     .Select(x => new AccountSubTypeDto()
                                     {
                                         Id = x.Id,
                                         Name = x.Name,
                                         Notes = x.Notes,
                                         Status = x.Status,
                                         AccountType = new Models.AccountType.AccountTypeDto()
                                         {
                                             Name = x.AccountType.Name,
                                             Id = x.AccountType.Id
                                         }
                                     }).FirstOrDefault();
        }
        [UnitOfWork]
        public async Task<bool> IsAccountSubTypeExistAsync(string name)
        {
            return await _accountSubTypeRepository.FirstOrDefaultAsync(x => x.Name == name.Trim()) != null;
        }
        [UnitOfWork]
        public async Task<bool> ChangeAccountSubTypeStatus(long id, ChangeLookupStatusInput input)
        {
            var record = await _accountSubTypeRepository.FirstOrDefaultAsync(x => x.Id == id);

            if (record == null)
                return false;

            return await ChangeStatusAsync(record, input.Status);
        }
        public async Task<IEnumerable<AccountSubTypeDto>> AccountSubTypesQueryAsync(GetLookupsInput input)
        {
            return await _accountSubTypeRepository.Query(x => x
                                 .Where(p => p.IsDeleted == input.DeletedOnly)
                                 .Skip(input.SkipCount)
                                 .Take(input.MaxResultCount)
                                 .Select(x => new AccountSubTypeDto()
                                 {
                                     Id = x.Id,
                                     Name = x.Name,
                                     Notes = x.Notes,
                                     Status = x.Status,
                                     AccountType = new Models.AccountType.AccountTypeDto()
                                     {
                                         Name = x.AccountType.Name,
                                         Id = x.AccountType.Id
                                     }
                                 }).ToListAsync());
        }
    }
}
