using EClinic.Framework.Data;
using EClinic.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace EClinic.Domain
{
    public class PatientTicketInClinic : DbEntity<User>
    {
        public string TicketNumber { get; set; }
        public TicketStatus Status { get; set; }

        [ForeignKey("PatientProfile")]
        public long PatientProfileId { get; set; }
        public PatientProfile PatientProfile { get; set; }

        [ForeignKey("Doctor")]
        public long DoctorId { get; set; }
        public User Doctor { get; set; }
    }
}