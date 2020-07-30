using System;

namespace EClinic.Core.Patients
{
    public class PatientQueryDto
    {
        public int Id { get; set; }
        public string IdNumber { get; set; }
        public string Name { get; set; }
        public string ProfileNumber { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string DoctorName { get; set; }
        public bool HasHealthInsurance { get; set; }
        public string InsuranceCompany { get; set; }
        public DateTime LastVisitDate { get; set; }
    }
}