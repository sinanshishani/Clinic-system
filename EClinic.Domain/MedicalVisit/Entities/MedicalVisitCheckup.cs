using EClinic.Framework.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace EClinic.Domain
{
    public class MedicalVisitCheckup : DbEntity<User>
    {
        public string Name { get; set; }
        public bool HasResult { get; set; }

        [ForeignKey("MedicalVisit")]
        public long MedicalVisitId { get; set; }
        public MedicalVisit MedicalVisit { get; set; }

        [ForeignKey("Result")]
        public long? ResultId { get; set; }
        public MedicalVisitCheckupResult Result { get; set; }
    }
}