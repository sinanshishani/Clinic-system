using EClinic.Framework.Data;
using EClinic.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EClinic.Domain
{
    public class PatientProfile : DbEntity<User>
    {
        [Required]
        public string IdNumber { get; set; }

        [Required]
        public string Name { get; set; }

        public string ProfileNumber { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime HeightWeightLastModificationTime { get; set; }

        public Gender Gender { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public bool? HasHealthInsurance { get; set; }

        public ICollection<PatientBiomatric> Biomatrics { get; set; }
        public ICollection<PatientFamilyDisease> FamilyDiseases { get; set; }
        public ICollection<PatientSurgicalDisease> SurgicalDiseases { get; set; }
        public ICollection<PatientInternalDisease> InternalDiseases { get; set; }
        public ICollection<PatientAllergic> Allergies { get; set; }
        public ICollection<PatientSurgery> Surgeries { get; set; }
        public string PermanentTreatments { get; set; }


        public long DoctorId { get; set; }

        [ForeignKey("Insurance")]
        public long? InsuranceId { get; set; }
        public PatientInsurance Insurance { get; set; }

        [ForeignKey("AdditionalInfo")]
        public long? PatientAdditionalInfoId { get; set; }
        public PatientAdditionalInfo AdditionalInfo { get; set; }
    }
}