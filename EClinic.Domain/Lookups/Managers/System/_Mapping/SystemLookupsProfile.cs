using Abp.Runtime.Session;
using Autofac;
using AutoMapper;
using EClinic.AppDomain.Lookups;
using EClinic.AppDomain.Lookups.Models;
using EClinic.Domain.Lookups;
using EClinic.Enums;
using System;

namespace EClinic.AppServices.SystemLookupsProfile.Mapping
{
    public class SystemLookupsProfile : Profile
    {
      //  private readonly Lazy<IAbpSession> abpSession;
        public SystemLookupsProfile(/*ILifetimeScope lifetimeScope*/)
        {
           // abpSession = new Lazy<IAbpSession>(() => lifetimeScope.Resolve<IAbpSession>()); ;

            #region Create
            CreateMap<CreateLookupInput, Lookup>()
                 .ForMember(d => d.CreationTime, opt => opt.MapFrom(s => DateTime.UtcNow))
                 .ForMember(d => d.Status, opt => opt.MapFrom(s => LookupStatus.Active))
                // .ForMember(d => d.CreatorUserId, opt => opt.MapFrom(s => abpSession.Value.UserId))
                 .ForMember(d => d.IsDeleted, opt => opt.MapFrom(s => false));

            CreateMap<CreateDiseaseInput, SystemBank>()
                .IncludeBase<CreateLookupInput, Lookup>();

            CreateMap<CreateAccountSubTypeInput, SystemAccountSubType>()
                .IncludeBase<CreateLookupInput, Lookup>();

            CreateMap<CreateMedicalVisitProcedureInput, SystemMedicalVisitProcedure>()
                          .IncludeBase<CreateLookupInput, Lookup>();

            CreateMap<CreateAccountTypeInput, SystemAccountType>()
                           .IncludeBase<CreateLookupInput, Lookup>();

            CreateMap<CreateComplaintInput, SystemComplaint>()
                          .IncludeBase<CreateLookupInput, Lookup>();

            CreateMap<CreateAccountTypeInput, SystemBank>()
                           .IncludeBase<CreateLookupInput, Lookup>();

            CreateMap<CreateDiseaseInput, SystemDisease>()
              .IncludeBase<CreateLookupInput, Lookup>();

            CreateMap<CreateDiagnosisInput, SystemDiagnosis>()
              .IncludeBase<CreateLookupInput, Lookup>();

            CreateMap<CreateDiagnosisInput, SystemDiagnosis>()
              .IncludeBase<CreateLookupInput, Lookup>();

            CreateMap<CreateSurgeryProcedureInput, SystemSurgeryProcedure>()
                .IncludeBase<CreateLookupInput, Lookup>();

            CreateMap<CreateDiagnosisInput, SystemDiagnosis>()
                .IncludeBase<CreateLookupInput, Lookup>();


            CreateMap<CreateSurgeryInput, SystemSurgery>()
                   .IncludeBase<CreateLookupInput, Lookup>();

            CreateMap<CreateBankInput, SystemBank>()
                .IncludeBase<CreateLookupInput, Lookup>();

            CreateMap<CreateAllergicInput, SystemAllergic>()
             .IncludeBase<CreateLookupInput, Lookup>();

            #endregion
            #region Edit 
            CreateMap<EditLookupInput, Lookup>()
                    .ForMember(d => d.LastModificationTime, opt => opt.MapFrom(s => DateTime.UtcNow));

            CreateMap<EditSurgeryProcedureInput, SystemSurgeryProcedure>()
              .IncludeBase<EditLookupInput, Lookup>();

            CreateMap<EditSurgeryInput, SystemSurgery>()
                   .IncludeBase<EditLookupInput, Lookup>();

            CreateMap<EditBankInput, SystemBank>()
                      .IncludeBase<EditLookupInput, Lookup>();

            CreateMap<EditComplaintInput, SystemComplaint>()
                      .IncludeBase<EditLookupInput, Lookup>();

            CreateMap<EditDiseaseInput, SystemDisease>()
                       .IncludeBase<EditLookupInput, Lookup>();

            CreateMap<EditDiagnosisInput, SystemDiagnosis>()
                         .IncludeBase<EditLookupInput, Lookup>();

            CreateMap<EditAllergicInput, SystemAllergic>()
                         .IncludeBase<EditLookupInput, Lookup>();



            CreateMap<EditMedicalVisitProcedureInput, SystemMedicalVisitProcedure>()
                                       .IncludeBase<EditLookupInput, Lookup>();

            CreateMap<EditAccountSubTypeInput, SystemAccountSubType>()
                 .IncludeBase<EditLookupInput, Lookup>();

            #endregion
        }
    }
}