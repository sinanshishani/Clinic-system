using EClinic.Framework.Data;
using EClinic.Enums;
using System.ComponentModel.DataAnnotations;

namespace EClinic.Domain
{
    public class PatientMedicalVisitProcedure : DbEntity<User>
    {
        [Required]
        //[ForeignKey("MedicalProcedure")]
        public long MedicalProcedureId { get; set; }
        //public MedicalProcedure MedicalProcedure { get; set; }

        [Required]
        public string MedicalProcedureName { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public ProcedureInsuranceStatus ProcedureInsuranceStatus { get; set; }

        [StringLength(500)]
        public string Notes { get; set; }


        public bool IsInsuranceApproved { get; set; }
        public string ApprovalNumber { get; set; }
        public int MedicalProceduresPayloadRatio { get; set; }
    }
}