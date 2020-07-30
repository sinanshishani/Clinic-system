using EClinic.Domain.Enums;
using EClinic.Framework.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace EClinic.Domain
{
    public class PatientAdditionalInfo : DbEntity<User>
    {
        public string Nationality { get; set; }

        public SocialStatus SocialStatus { get; set; }
        public int FamilyMembersCount { get; set; }
        public double FamilyIncome { get; set; }
        public EducationalLevel EducationalLevel { get; set; }
        public string Job { get; set; }

        [ForeignKey("PatientProfile")]
        public long PatientProfileId { get; set; }
        public PatientProfile PatientProfile { get; set; }
    }
}