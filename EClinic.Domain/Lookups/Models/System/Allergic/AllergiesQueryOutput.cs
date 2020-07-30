using EClinic.AppDomain.Lookups.Models.Bank.Dto;
using System.Collections.Generic;

namespace EClinic.Core.Lookups
{
    public class AllergiesQueryOutput
    {
        public IEnumerable<LookupDto> Allergies { get; set; }
    }
}