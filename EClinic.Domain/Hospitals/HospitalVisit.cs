using EClinic.Framework.Data;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EClinic.Domain
{
    public class HospitalVisit : DbEntity<User>
    {
        [Required]
        [Column(TypeName = "datetime2")]
        public DateTime Date { get; set; }

        [Required]
        public string Reason { get; set; }
        public string Note { get; set; }
        
        [Required]
        public string Status { get; set; }

        public string ReportFileUrl { get; set; }
        public bool IsValidInsurance { get; set; }
        public bool HasProcedure { get; set; }
        [Required]
        public double DoctorFeesPrice { get; set; }
        [Required]
        public double TotalPrice { get; set; }
        [Required]
        public string PaymentNote { get; set; }

        [ForeignKey("Doctor")]
        public long DcotorId { get; set; }
        public User Doctor { get; set; }

        [ForeignKey("Hospital")]
        public long HospitalId { get; set; }
        public Hospital Hospital { get; set; }

        [ForeignKey("PatientProfile")]
        public long PatientProfileId { get; set; }
        public PatientProfile PatientProfile { get; set; }
    }
}