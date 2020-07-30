using EClinic.Domain.Lookups;
using EClinic.Framework.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace EClinic.Domain
{
    public class MedicalVisitComplaint : DbEntity<User>
    {
        [ForeignKey("Complaint")]
        public long ComplaintId { get; set; }
        public Complaint Complaint { get; set; }

        [ForeignKey("MedicalVisit")]
        public long MedicalVisitId { get; set; }
        public MedicalVisit MedicalVisit { get; set; }
    }
}