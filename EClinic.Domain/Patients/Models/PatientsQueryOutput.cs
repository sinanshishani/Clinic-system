using System.Collections.Generic;

namespace EClinic.Core.Patients
{
    public class PatientsQueryOutput
    {
        public IEnumerable<PatientQueryDto> Patients { get; set; }
    }
}