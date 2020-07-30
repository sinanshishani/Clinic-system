using EClinic.Framework.Data;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace EClinic.Domain
{
    public class PatientAppointment : DbEntity<User>
    {
        [Column(TypeName = "date")]
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public string Note { get; set; }

        [ForeignKey("Doctor")]
        public long DoctorId { get; set; }
        public User Doctor { get; set; }
    }
}
