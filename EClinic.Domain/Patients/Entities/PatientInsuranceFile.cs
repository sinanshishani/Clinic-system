using EClinic.Framework.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace EClinic.Domain
{
    public class PatientInsuranceFile : CreationAuditedDbEntity<User>
    {
        public string Url { get; set; }

        [ForeignKey("PatientInsurance")]
        public long PatientInsuranceId { get; set; }
        public PatientInsurance PatientInsurance { get; set; }
    }
}