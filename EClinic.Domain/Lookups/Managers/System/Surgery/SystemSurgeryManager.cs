using Abp.Domain.Services;
using Abp.Domain.Uow;
using EClinic.AppDomain.Lookups.Models;
using EClinic.AppDomain.Lookups.Models.Bank.Dto;
using EClinic.AppDomain.Lookups.Models.Surgery;
using EClinic.AppDomain.Lookups.Models.SurgeryProcedure;
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
        public async Task<long> CreateSurgeryAsync(CreateSurgeryInput input)
        {

            input.SurgeriesProceduresIds = input.SurgeriesProceduresIds.Distinct().ToList();

            var surgery = _mapper.Map<SystemSurgery>(input);

            var id = await _surgeryRepository.InsertAndGetIdAsync(surgery);

            var systemSurgeryProcedures = await _surgeryProcedureRepository.GetAll().Where(x =>
                                                                            input.SurgeriesProceduresIds.Contains(x.Id))
                                                     .Select(x => new SystemSurgeriesProcedures
                                                     {
                                                         SurgeryId = id,
                                                         SurgeryProcedureId = x.Id
                                                     }).ToListAsync();

            foreach(var item in systemSurgeryProcedures)
            await _surgeriesProceduresRepository.InsertAsync(item);



            await CurrentUnitOfWork.SaveChangesAsync();

            return surgery.Id;


        }
        [UnitOfWork]
        public async Task<bool> EditSurgeryAsync(long id, EditSurgeryInput input)
        {
            var record = await _surgeryRepository.FirstOrDefaultAsync(x => x.Id == id);

            if (record == null)
                return false;

            await _surgeriesProceduresRepository.DeleteAsync(x => x.SurgeryId == record.Id);
 
            input.SurgeriesProceduresIds = input.SurgeriesProceduresIds.Distinct().ToList();

            _mapper.Map(input, record);

            record.LastModifierUserId = GetCurrentUser();


            var systemSurgeryProcedures = await _surgeryProcedureRepository.GetAll().Where(x =>
                                                                            input.SurgeriesProceduresIds.Contains(x.Id))
                                                     .Select(x => new SystemSurgeriesProcedures
                                                     {
                                                         SurgeryId = record.Id,
                                                         SurgeryProcedureId = x.Id
                                                     }).ToListAsync();

            foreach (var item in systemSurgeryProcedures)
                await _surgeriesProceduresRepository.InsertAsync(item);


            await CurrentUnitOfWork.SaveChangesAsync();

            return true;


        }
        public async Task<bool> IsSurgeryExistAsync(string name)
        {
            return await _surgeryProcedureRepository.FirstOrDefaultAsync(x => x.Name == name.Trim()) != null;
        }
        [UnitOfWork]
        public async Task<bool> ChangeSurgeryProcedureStatus(long id, ChangeLookupStatusInput input)
        {
            var record = await _surgeryRepository.FirstOrDefaultAsync(x => x.Id == id);

            if (record == null)
                return false;

            return await ChangeStatusAsync(record, input.Status);
        }
        public async Task<IEnumerable<LookupDto>> SurgeriesQueryAsync(GetLookupsInput input)
        {
            return await _surgeryRepository.Query(x => x
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
        public async Task<SurgeryDto> GetSurgeryAsync(long id)
        {

            return _surgeryRepository.Query(surgery => surgery
                                           .Include(p => p.SurgeriesProcedures)
                                           .Where(x => x.Id == id))
                                           .Select(x => new SurgeryDto()
                                           {
                                               id = x.Id,
                                               Name = x.Name,
                                               SurgeriesProcedures = x.SurgeriesProcedures.Where(y=> y.IsDeleted != true)
                                               .Select(y => new SurgeryProcedureDto
                                               {
                                                   Id = y.SurgeryProcedure.Id,
                                                   Number = y.SurgeryProcedure.Number.ToString(),
                                                   Points = y.SurgeryProcedure.Points
                                               }).ToList()
                                           }).FirstOrDefault();
        }

    }
}
