using Abp.Domain.Services;
using Abp.Domain.Uow;
using Abp.Runtime.Session;
using EClinic.AppDomain.Lookups.Models;
using EClinic.AppDomain.Lookups.Models.Bank.Dto;
using EClinic.AppDomain.Lookups.Models.Shared;
using EClinic.Domain.Lookups;
using EClinic.Enums;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EClinic.AppDomain.Lookups
{
    public partial class SystemLookupsManager : DomainService, ISystemLookupsManager
    {
        [UnitOfWork]
        public async Task<long> CreateMedicalVisitProcedureAsync(CreateMedicalVisitProcedureInput input)
        {
            var record = _mapper.Map<SystemMedicalVisitProcedure>(input);
            record.CreatorUserId = GetCurrentUser();

            await _medicalVisitProcedureRepository.InsertAsync(record);

            await CurrentUnitOfWork.SaveChangesAsync();

            return record.Id;
        }
        [UnitOfWork]
        public async Task<bool> EditMedicalVisitProcedureAsync(long id, EditMedicalVisitProcedureInput input)
        {
            var record = await _medicalVisitProcedureRepository.FirstOrDefaultAsync(x => x.Id == id);

            if (record == null)
                return false;

            _mapper.Map(input, record);
            record.LastModifierUserId = GetCurrentUser();

            await CurrentUnitOfWork.SaveChangesAsync();

            return true;
        }
        public async Task<LookupDto> GetMedicalVisitProcedureAsync(long id)
        {
            return _medicalVisitProcedureRepository.GetAll()
                                     .Where(x => x.Id == id)
                                     .Select(x => new LookupDto()
                                     {
                                         Id = x.Id,
                                         Name = x.Name,
                                         Status = x.Status
                                     }).FirstOrDefault();
        }
        [UnitOfWork]
        public async Task<bool> IsMedicalVisitProcedureExistAsync(string name)
        {
            return await _medicalVisitProcedureRepository.FirstOrDefaultAsync(x => x.Name == name.Trim()) != null;
        }
        [UnitOfWork]
        public async Task<bool> ChangeMedicalVisitProcedureStatus(long id, ChangeLookupStatusInput input)
        {
            var record = await _medicalVisitProcedureRepository.FirstOrDefaultAsync(x => x.Id == id);

            if (record == null)
                return false;

            return await ChangeStatusAsync(record, input.Status);
        }
        public async Task<IEnumerable<LookupDto>> MedicalVisitProceduresQueryAsync(GetLookupsInput input)
        {
            return await _medicalVisitProcedureRepository.Query(x => x
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
