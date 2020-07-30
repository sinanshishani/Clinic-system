using EClinic.Framework.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EClinic.Domain
{
    public class MedicalVisit : DbEntity<User>
    {
        [Required]
        public DateTime Time { get; set; }
        
        [ForeignKey("Doctor")]
        public long DoctorId { get; set; }
        public User Doctor { get; set; }

        [Required]
        [ForeignKey("Complaint")]
        public long ComplaintId { get; set; }
        public MedicalVisitComplaintDetails Complaint { get; set; }

        [StringLength(500)]
        public string ComplaintDetails { get; set; }

        [Required]
        [ForeignKey("Diagnosis")]
        public long DiagnosisId { get; set; }
        public MedicalVisitDiagnosis Diagnosis { get; set; }

        [StringLength(500)]
        public string DiagnosisDetails { get; set; }

        [StringLength(500)]
        public string VisitNotes { get; set; }

        public ICollection<MedicalVisitCheckup> Checkups { get; set; }

        public ICollection<MedicalVisitXRay> XRays { get; set; }

        public ICollection<MedicalVisitMedicine> Medicines { get; set; }

        [StringLength(500)]
        public string InsuranceFormNumber { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public double PatientPricePayload { get; set; }

        [Required]
        public double MedicalProceduresPrice { get; set; }

        [Required]
        public double PatientMedicalProceduresPricePayload { get; set; }

        [Required]
        public double PatientPayloadTotal { get; set; }

        [Required]
        public double TotalPrice { get; set; }

        public bool NeedHospitalAdmission { get; set; }
        public string HospitalAdmissionNotes { get; set; }
        public bool NeedCheckUp { get; set; }
        public bool NeedMedicine { get; set; }
        public bool NeedXRay { get; set; }
        public bool NeedMedicalPrcedure { get; set; }
        public bool IsInsuranceActive { get; set; }
    }
}