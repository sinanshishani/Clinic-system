using EClinic.AppDomain.Lookups.Models.Bank.Dto;
using System.Collections.Generic;

namespace EClinic.Core.Lookups
{
    public class MedicalVisitProceduresQueryOutput
    {
        public IEnumerable<LookupDto> MedicalVisitProcedures { get; set; }
    }
}