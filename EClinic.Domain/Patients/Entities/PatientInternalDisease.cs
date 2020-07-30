using EClinic.Framework.Data;
using EClinic.Domain.Lookups;
using System.ComponentModel.DataAnnotations.Schema;

namespace EClinic.Domain
{
    public class PatientInternalDisease : CreationAuditedDbEntity<User>
    {
        [ForeignKey("Disease")]
        public long DiseaseId { get; set; }
        public Disease Disease { get; set; }

        [ForeignKey("PatientProfile")]
        public long PatientProfileId { get; set; }
        public PatientProfile PatientProfile { get; set; }
    }
}