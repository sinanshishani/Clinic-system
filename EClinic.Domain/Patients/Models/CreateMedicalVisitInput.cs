using EClinic.Framework.Validation.Attributes;
using System;
using System.ComponentModel.DataAnnotations;

namespace EClinic.Domain.Patients
{
    public class CreateMedicalVisitInput
    {
        [Required]
        [PastOrPresentDate]
        public DateTime VisitTime { get; set; }
        
        [Required]
        public long DoctorId { get; set; }

        public long MedicalVistComplaintId { get; set; }
        public MedicalVisitComplaintDetails MedicalVistComplaint { get; set; }

        [StringLength(500)]
        public string ComplaintDetails { get; set; }

        [Required]
        //[ForeignKey("Diagnosis")]
        public long DiagnosisId { get; set; }
        //public Diagnosis Diagnosis { get; set; }

        [StringLength(500)]
        public string DiagnosisDetails { get; set; }

        [StringLength(500)]
        public string VisitNotes { get; set; }

        //public ICollection<MedicalCheckUp> MedicalCheckUps { get; set; }

        //public ICollection<XRayAndSpeculum> XRayAndSpeculums { get; set; }

        [StringLength(500)]
        public string HospitalAdmission { get; set; }

        //public ICollection<Drug> Drugs { get; set; }

        //public ICollection<DrugUsage> DrugUsages { get; set; }

        [StringLength(500)]
        public string InsuranceFormNumber { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public double PricePatientPayload { get; set; }

        [Required]
        public double MedicalProceduresPrice { get; set; }

        [Required]
        public double MedicalProceduresPricePatientPayload { get; set; }

        [Required]
        public double PatientPayloadTotal { get; set; }

        [Required]
        public double Total { get; set; }
    }
}