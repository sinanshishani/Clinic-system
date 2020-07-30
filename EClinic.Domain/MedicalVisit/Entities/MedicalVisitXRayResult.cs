using EClinic.Framework.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace EClinic.Domain
{
    public class MedicalVisitXRayResult : DbEntity<User>
    {
        [ForeignKey("XRay")]
        public long XRayId { get; set; }
        public MedicalVisitXRay XRay { get; set; }

        public string LabName { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string DoctorNotes { get; set; }

        public ICollection<MedicalVisitXRayResultFile> Files { get; set; }
    }
}
