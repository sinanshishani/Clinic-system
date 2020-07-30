using Abp.Domain.Entities;
using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Abp.Domain.Uow;
using Abp.Runtime.Session;
using AutoMapper;
using EClinic.AppDomain.Lookups.Models;
using EClinic.Domain;
using EClinic.Domain.Lookups;
using EClinic.Enums;
using EClinic.Framework.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EClinic.AppDomain.Lookups
{
    public partial class SystemLookupsManager : DomainService, ISystemLookupsManager
    {
        private readonly IMapper _mapper;
        private readonly IAbpSession _abpSession;
        public List<IRepository> Repositories { get; }
        private readonly object _repositoriesLock = new object();
        private readonly IRepository<SystemBank, long> _bankRepository;
        private readonly IRepository<SystemDiagnosis, long> _diagnosisRepository;
        private readonly IRepository<SystemAllergic, long> _allergicRepository;
        private readonly IRepository<SystemComplaint, long> _complaintRepository;
        private readonly IRepository<SystemDisease, long> _diseaseRepository;
        private readonly IRepository<SystemMedicalVisitProcedure, long> _medicalVisitProcedureRepository;
        private readonly IRepository<SystemAccountType, long> _accountTypeRepository;
        private readonly IRepository<SystemAccountSubType, long> _accountSubTypeRepository;
        private readonly IRepository<SystemSubscriptionDuration, long> _subscriptionDurationRepository;
        private readonly IRepository<SystemSubscriptionPlan, long> _subscriptionPlanRepository;
        private readonly IRepository<SystemSurgeryProcedure, long> _surgeryProcedureRepository;
        private readonly IRepository<SystemSurgeriesProcedures, long> _surgeriesProceduresRepository;
        private readonly IRepository<SystemSurgery, long> _surgeryRepository;

        public SystemLookupsManager(
            IMapper mapper,
            IAbpSession abpSession,
            IRepository<SystemBank, long> bankRepository,
            IRepository<SystemDiagnosis, long> diagnosisRepository,
            IRepository<SystemAllergic, long> allergicRepository,
            IRepository<SystemComplaint, long> complaintRepository,
            IRepository<SystemDisease, long> diseaseRepository,
            IRepository<SystemMedicalVisitProcedure, long> medicalVisitProcedureRepository,
            IRepository<SystemAccountType, long> accountTypeRepository,
            IRepository<SystemAccountSubType, long> accountSubTypeRepository,
            IRepository<SystemSubscriptionDuration, long> subscriptionDurationRepository,
            IRepository<SystemSubscriptionPlan, long> subscriptionPlanRepository,
            IRepository<SystemSurgeryProcedure, long> surgeryProcedureRepository,
            IRepository<SystemSurgeriesProcedures, long> surgeriesProceduresRepository,
            IRepository<SystemSurgery, long> surgeryRepository
            )
        {
            _mapper = mapper;
            _abpSession = abpSession;
           Repositories.AddRange( new List<IRepository>()
           {
                 bankRepository,
                 diagnosisRepository,
                 bankRepository,
                 diagnosisRepository,
                 allergicRepository,
                 complaintRepository,
                 diseaseRepository,
                 medicalVisitProcedureRepository,
                 accountSubTypeRepository,
                 subscriptionDurationRepository,
                 subscriptionPlanRepository,
                 surgeryProcedureRepository,
                 surgeriesProceduresRepository,
                 surgeryRepository,
                 accountTypeRepository
           });

        }

        public IRepository<TEntity, long> Repository<TEntity>()
            where TEntity : Entity<long>
        {
            lock (_repositoriesLock)
            {
                if (!Repositories.OfType<IRepository<TEntity, long>>().Any())
                {
                    throw new Exception($"Repository Type not found");
                }

                return Repositories.OfType<IRepository<TEntity, long>>().FirstOrDefault();
            }
        }

        [UnitOfWork]
        public async Task<long> Create<TEntity>(CreateLookupInput input) where TEntity : Entity<long>
        {
            var record = _mapper.Map<TEntity>(input);

            await Repository<TEntity>().InsertAsync(record);

            await CurrentUnitOfWork.SaveChangesAsync();

            return record.Id;
        }

        [UnitOfWork]
        public async Task<bool> ChangeStatusAsync<type>(type record, LookupStatus status) where type : Lookup
        {

            record.Status = status;
            await CurrentUnitOfWork.SaveChangesAsync();
            return true;
        }
        public long GetCurrentUser()
        {
            return _abpSession.GetUserId();
        }

    }
}
