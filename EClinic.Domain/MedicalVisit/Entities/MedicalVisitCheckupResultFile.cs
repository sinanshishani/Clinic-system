using EClinic.Framework.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace EClinic.Domain
{
    public class MedicalVisitCheckupResultFile : CreationAuditedDbEntity<User>
    {
        public string Name { get; set; }

        [ForeignKey("Result")]
        public long ResultId { get; set; }
        public MedicalVisitCheckupResult Result { get; set; }
    }
}