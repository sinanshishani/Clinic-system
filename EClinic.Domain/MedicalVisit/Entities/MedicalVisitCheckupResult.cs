using EClinic.Framework.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace EClinic.Domain
{
    public class MedicalVisitCheckupResult : DbEntity<User>
    {
        [ForeignKey("Checkup")]
        public long CheckupId { get; set; }
        public MedicalVisitCheckup Checkup { get; set; }

        public string LabName { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string DoctorNotes { get; set; }

        public ICollection<MedicalVisitCheckupResultFile> Files { get; set; }
    }
}