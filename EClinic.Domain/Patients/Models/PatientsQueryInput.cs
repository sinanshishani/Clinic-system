using Abp.Application.Services.Dto;
using EClinic.Domain.Enums;
using EClinic.Framework.Validation.Attributes;
using System.ComponentModel.DataAnnotations;

namespace EClinic.Core.Patients
{
    public class PatientsQueryInput : IPagedResultRequest
    {
        public int PatientId { get; set; }

        [StringNumber]
        [StringLength(10, MinimumLength = 10)]
        public string IdNumber { get; set; }

        [StringInSingleLanguage]
        public string Name { get; set; }

        [StringNumber]
        public string ProfileNumber { get; set; }

        [StringNumber]
        [StringLength(10, MinimumLength = 10)]
        [StringStartWith("07")]
        public string PhoneNumber { get; set; }

        public Gender Gender { get; set; }

        [EmailAddress]
        [MaxLength(200)]
        public string Email { get; set; }

        public long DoctorId { get; set; }

        public long InsuranceCompanyId { get; set; }

        public bool HasHealthInsurance { get; set; }

        public int SkipCount { get; set; }
        public int MaxResultCount { get; set; }
    }
}