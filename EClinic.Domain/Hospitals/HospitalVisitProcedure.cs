using EClinic.Domain.Lookups;
using EClinic.Framework.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace EClinic.Domain
{
    public class HospitalVisitProcedure : CreationAuditedDbEntity<User>
    {
        [ForeignKey("SurgeryProcedure")]
        public long SurgeryProcedureId { get; set; }
        public SurgeryProcedure SurgeryProcedure { get; set; }

        [ForeignKey("HospitalVisit")]
        public long HospitalVisitId { get; set; }
        public HospitalVisit HospitalVisit { get; set; }
    }
}