using EClinic.Domain.Lookups;
using EClinic.Framework.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace EClinic.Domain
{
    public class MedicalVisitDiagnosis : DbEntity<User>
    {
        [ForeignKey("MedicalVisit")]
        public long MedicalVisitId { get; set; }
        public MedicalVisit MedicalVisit { get; set; }

        [ForeignKey("Diagnosis")]
        public long DiagnosisId { get; set; }
        public Diagnosis Diagnosis { get; set; }
    }
}