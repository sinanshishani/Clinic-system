using EClinic.AppDomain.Lookups.Models.Bank.Dto;
using System.Collections.Generic;

namespace EClinic.Core.Lookups
{
    public class AccountSubTypesQueryOutput
    {
        public IEnumerable<AccountSubTypeDto> AccountSubTypes { get; set; }
    }
}