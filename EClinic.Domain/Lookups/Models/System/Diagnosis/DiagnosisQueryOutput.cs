using EClinic.AppDomain.Lookups.Models.Bank.Dto;
using System.Collections.Generic;

namespace EClinic.Core.Lookups
{
    public class DiagnosisQueryOutput
    {
        public IEnumerable<LookupDto> Diagnoses { get; set; }
    }
}