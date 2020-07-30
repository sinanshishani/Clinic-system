using EClinic.AppDomain.Lookups.Models.Bank.Dto;
using System.Collections.Generic;

namespace EClinic.Core.Lookups
{
    public class BanksQueryOutput
    {
        public IEnumerable<LookupDto> Banks { get; set; }
    }
}