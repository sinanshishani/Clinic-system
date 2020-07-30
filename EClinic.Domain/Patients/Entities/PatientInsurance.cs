using EClinic.Framework.Data;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EClinic.Domain
{
    public class PatientInsurance : DbEntity<User>
    {
        [Required]
        public string InsuranceNumber { get; set; }
        [Required]
        public int MedicalVisitPayloadRate { get; set; }
        [Required]
        public int MedicalProceduresPayloadRate { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime ExpiryDate { get; set; }

        public int DoctorVisitRateType { get; set; }
        public double DoctorVisitRate { get; set; }

        public bool IsActive { get; set; }

        [StringLength(200)]
        public string Notes { get; set; }

        [ForeignKey("PatientProfile")]
        public long PatientProfileId { get; set; }
        public PatientProfile PatientProfile { get; set; }

        [ForeignKey("InsuranceCompany")]
        public long InsuranceCompanyId { get; set; }
        public InsuranceCompany InsuranceCompany { get; set; }
    }
}