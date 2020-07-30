using EClinic.Framework.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace EClinic.Domain
{
    public class MedicalVisitXRayResultFile : CreationAuditedDbEntity<User>
    {
        public string Name { get; set; }

        [ForeignKey("Result")]
        public long ResultId { get; set; }
        public MedicalVisitXRayResult Result { get; set; }
    }
}