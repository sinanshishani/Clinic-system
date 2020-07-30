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
        public async Task<long> CreateSurgeryProcedureAsync(CreateSurgeryProcedureInput input)
        {
            try
            {

                var record = _mapper.Map<SystemSurgeryProcedure>(input);
                record.CreatorUserId = GetCurrentUser();

                await _surgeryProcedureRepository.InsertAsync(record);

                await CurrentUnitOfWork.SaveChangesAsync();

                return record.Id;

            }
            catch (System.Exception ex)
            {

                throw;
            }
        }
        [UnitOfWork]
        public async Task<bool> EditSurgeryProcedureAsync(long id, EditSurgeryProcedureInput input)
        {
            var record = await _surgeryProcedureRepository.FirstOrDefaultAsync(x => x.Id == id);

            if (record == null)
                return false;

            _mapper.Map(input, record);
            record.LastModifierUserId = GetCurrentUser();

            await CurrentUnitOfWork.SaveChangesAsync();

            return true;
        }
        [UnitOfWork]
        public async Task<bool> IsSurgeryProcedureExistAsync(string name)
        {
            return await _surgeryProcedureRepository.FirstOrDefaultAsync(x => x.Name == name.Trim()) != null;
        }
        [UnitOfWork]
        public async Task<bool> ChangeSurgeryStatus(long id, ChangeLookupStatusInput input)
        {
            var record = await _surgeryProcedureRepository.FirstOrDefaultAsync(x => x.Id == id);

            if (record == null)
                return false;

            return await ChangeStatusAsync(record, input.Status);
        }
        public async Task<IEnumerable<LookupDto>> SurgeryProceduresQueryAsync(GetLookupsInput input)
        {
            return await _surgeryProcedureRepository.Query(x => x
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
