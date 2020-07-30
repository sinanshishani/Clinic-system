using EClinic.Domain.Enums;
using EClinic.Framework.Validation.Attributes;
using System;
using System.ComponentModel.DataAnnotations;

namespace EClinic.Core.Patients
{
    public class CreatePatientInput
    {
        [Required]
        [StringNumber]
        [StringLength(10, MinimumLength = 10)]
        public string IdNumber { get; set; }

        [Required]
        [StringInSingleLanguage]
        public string Name { get; set; }

        [StringNumber]
        public string ProfileNumber { get; set; }

        [Required]
        [StringNumber]
        [StringLength(10, MinimumLength = 10)]
        [StringStartWith("07")]
        public string PhoneNumber { get; set; }

        [Required]
        [PastDate]
        public DateTime BirthDate { get; set; }

        [IntegerLength(3)]
        public int? Height { get; set; }
        [IntegerLength(3)]
        public int? Weight { get; set; }

        public Gender Gender { get; set; }

        [EmailAddress]
        [MaxLength(200)]
        public string Email { get; set; }

        [MaxLength(200)]
        public string Address { get; set; }
        public bool HasHealthInsurance { get; set; }

        #region Additional Info
        [MaxLength(200)]
        public string Nationality { get; set; }
        public SocialStatus? SocialStatus { get; set; }

        [Range(minimum: 1, maximum: 99)]
        public int? FamilyMembersCount { get; set; }

        [Range(minimum: 1, maximum: 999999)]
        public int? FamilyIncome { get; set; }
        public EducationalLevel? EducationalLevel { get; set; }
        public string Job { get; set; }

        [Range(minimum: 1, maximum: 10)]
        public int? PainDegree { get; set; }

        //public ICollection<string> FamilyDiseases { get; set; }
        //public ICollection<string> SurgicalDiseases { get; set; }
        //public ICollection<string> InternalDiseases { get; set; }
        //public ICollection<string> Sensitivity { get; set; }

        [MaxLength(200)]
        public string Surgeries { get; set; }

        [MaxLength(200)]
        public string PermanentTreatments { get; set; }
        #endregion

        [Required]
        public long DoctorId { get; set; }

        [Required]
        public string InsuranceNumber { get; set; }

        [Required]
        [Range(minimum: 0, maximum: 100)]
        public int MedicalVisitPayloadRatio { get; set; }

        [Required]
        [Range(minimum: 0, maximum: 100)]
        public int MedicalProceduresPayloadRatio { get; set; }

        [Required]
        [PastOrPresentDate]
        public DateTime StartDate { get; set; }

        [Required]
        [PresentOrFutureDate]
        public DateTime ExpiryDate { get; set; }

        [MaxLength(200)]
        public string Notes { get; set; }

        public long InsuranceCompanyId { get; set; }
    }
}