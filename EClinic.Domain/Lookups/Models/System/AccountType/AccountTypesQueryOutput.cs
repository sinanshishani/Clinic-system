using EClinic.AppDomain.Lookups.Models.Bank.Dto;
using System.Collections.Generic;

namespace EClinic.Core.Lookups
{
    public class AccountTypesQueryOutput
    {
        public IEnumerable<LookupDto> AccountTypes { get; set; }
    }
}