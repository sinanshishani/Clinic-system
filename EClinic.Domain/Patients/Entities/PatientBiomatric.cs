using EClinic.Framework.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace EClinic.Domain
{
    public class PatientBiomatric : DbEntity<User>
    {
        public int? PainParecentage { get; set; }
        public int? Height { get; set; }
        public int? Weight { get; set; }

        [ForeignKey("PatientProfile")]
        public long PatientProfileId { get; set; }
        public PatientProfile PatientProfile { get; set; }

        [ForeignKey("MedicalVisit")]
        public long? MedicalVisitId { get; set; }
        public MedicalVisit MedicalVisit { get; set; }
    }
}