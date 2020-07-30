using EClinic.AppDomain.Lookups.Models.Bank.Dto;
using System.Collections.Generic;

namespace EClinic.Core.Lookups
{
    public class SurgeriesQueryOutput
    {
        public IEnumerable<LookupDto> Surgeries { get; set; }
    }
}