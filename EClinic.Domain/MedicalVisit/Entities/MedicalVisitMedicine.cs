using EClinic.Framework.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace EClinic.Domain
{
    public class MedicalVisitMedicine : DbEntity<User>
    {
        public string Name { get; set; }
        public string HowToUse { get; set; }

        [ForeignKey("MedicalVisit")]
        public long MedicalVisitId { get; set; }
        public MedicalVisit MedicalVisit { get; set; }
    }
}