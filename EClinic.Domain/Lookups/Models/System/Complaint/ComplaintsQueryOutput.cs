using EClinic.AppDomain.Lookups.Models.Bank.Dto;
using System.Collections.Generic;

namespace EClinic.Core.Lookups
{
    public class ComplaintsQueryOutput
    {
        public IEnumerable<LookupDto> Complaints { get; set; }
    }
}