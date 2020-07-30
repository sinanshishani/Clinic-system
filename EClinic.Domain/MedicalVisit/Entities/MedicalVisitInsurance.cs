using EClinic.Framework.Data;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace EClinic.Domain
{
    public class MedicalVisitInsurance : DbEntity<User>
    {
        public string FormNumber { get; set; }
        public string FormUrl { get; set; }
        public string InsuranceNumber { get; set; }
        public double InRate { get; set; }
        public double OutRate { get; set; }
        public string DoctorVisitRateType { get; set; }
        public double DoctorVisitRate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ExpiryDate { get; set; }

        [ForeignKey("MedicalVisit")]
        public long MedicalVisitId { get; set; }
        public MedicalVisit MedicalVisit { get; set; }
    }
}