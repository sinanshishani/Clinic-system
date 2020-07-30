using EClinic.Domain.Lookups;
using EClinic.Framework.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace EClinic.Domain
{
    public class PatientAllergic : CreationAuditedDbEntity<User>
    {
        [ForeignKey("Allergic")]
        public long AllergicId { get; set; }
        public Allergic Allergic { get; set; }

        [ForeignKey("PatientProfile")]
        public long PatientProfileId { get; set; }
        public PatientProfile PatientProfile { get; set; }
    }
}