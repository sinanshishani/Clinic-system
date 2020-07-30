using EClinic.Framework.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EClinic.Domain.Patients.Entities
{
    public class PermanentTreatment : CreationAuditedDbEntity<User>
    {
        [Required]
        public string Name { get; set; }

        [ForeignKey("PatientProfile")]
        public long PatientProfileId { get; set; }
        public PatientProfile PatientProfile { get; set; }
    }
}