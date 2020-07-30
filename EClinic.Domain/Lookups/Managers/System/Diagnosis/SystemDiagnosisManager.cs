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
        public async Task<long> CreateDiagnosisAsync(CreateDiagnosisInput input)
        {
            try
            {

            var record = _mapper.Map<SystemDiagnosis>(input);
            record.CreatorUserId = GetCurrentUser();

                await _diagnosisRepository.InsertAsync(record);

            await CurrentUnitOfWork.SaveChangesAsync();

            return record.Id;

            }
            catch (System.Exception ex)
            {

                throw;
            }
        }
        [UnitOfWork]
        public async Task<bool> EditDiagnosisAsync(long id, EditDiagnosisInput input)
        {
            var record = await _diagnosisRepository.FirstOrDefaultAsync(x => x.Id == id);

            if (record == null)
                return false;

            _mapper.Map(input, record);
            record.LastModifierUserId = GetCurrentUser();

            await CurrentUnitOfWork.SaveChangesAsync();

            return true;
        }
        public async Task<LookupDto> GetDiagnosisAsync(long id)
        {
            return _diagnosisRepository.GetAll()
                                     .Where(x => x.Id == id)
                                     .Select(x => new LookupDto()
                                     {
                                         Id = x.Id,
                                         Name = x.Name,
                                         Status = x.Status
                                     }).FirstOrDefault();
        }
        [UnitOfWork]
        public async Task<bool> IsDiagnosisExistAsync(string name)
        {
            return await _diagnosisRepository.FirstOrDefaultAsync(x => x.Name == name.Trim()) != null;
        }
        [UnitOfWork]
        public async Task<bool> ChangeDiagnosisStatus(long id, ChangeLookupStatusInput input)
        {
            var record = await _diagnosisRepository.FirstOrDefaultAsync(x => x.Id == id);
            record.Status = input.Status;
            await CurrentUnitOfWork.SaveChangesAsync();
            return true;
        }
        public async Task<IEnumerable<LookupDto>> DiagnosesQueryAsync(GetLookupsInput input)
        {
            return await _diagnosisRepository.Query(x => x
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
