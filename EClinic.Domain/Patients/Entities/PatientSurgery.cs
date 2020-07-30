using EClinic.Framework.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EClinic.Domain
{
    public class PatientSurgery : CreationAuditedDbEntity<User>
    {
        [Required]
        public string Name { get; set; }

        [ForeignKey("PatientProfile")]
        public long PatientProfileId { get; set; }
        public PatientProfile PatientProfile { get; set; }
    }
}