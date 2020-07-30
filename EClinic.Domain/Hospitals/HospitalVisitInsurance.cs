using EClinic.Framework.Data;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EClinic.Domain
{
    public class HospitalVisitInsurance : CreationAuditedDbEntity<User>
    {
        [Required]
        public string FormNumber { get; set; }
        
        [Required]
        public string ApprovalNumber { get; set; }

        [Required]
        public string InsuranceNumber { get; set; }

        [Required]
        public int InRate { get; set; }

        [Required]
        public int OutRate { get; set; }

        [Required]
        public string DoctorVisitRateType { get; set; }

        [Required]
        public double DoctorVisitRate { get; set; }

        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime ExpiryDate { get; set; }

        [ForeignKey("HospitalVisit")]
        public long HospitalVisitId { get; set; }
        public HospitalVisit HospitalVisit { get; set; }
    }
}