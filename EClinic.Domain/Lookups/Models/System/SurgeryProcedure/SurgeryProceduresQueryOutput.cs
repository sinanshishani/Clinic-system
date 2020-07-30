using EClinic.AppDomain.Lookups.Models.Bank.Dto;
using System.Collections.Generic;

namespace EClinic.Core.Lookups
{
    public class SurgeryProceduresQueryOutput
    {
        public IEnumerable<LookupDto> SurgeryProcedures { get; set; }
    }
}