using EClinic.AppDomain.Lookups.Models.Bank.Dto;
using System.Collections.Generic;

namespace EClinic.Core.Lookups
{
    public class DiseasesQueryOutput
    {
        public IEnumerable<LookupDto> Diseases { get; set; }
    }
}